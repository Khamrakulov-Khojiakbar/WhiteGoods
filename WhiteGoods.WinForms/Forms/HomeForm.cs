using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class HomeForm : Form
    {
        private bool statusDataLoaded = false;
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        private DataTable dataTable = new DataTable();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"select 
                                        s.date_receipt,
                                        s.id,
                                        CONCAT(s.client_firstname, ' ', s.client_lastname) AS client_firstname,
                                        s.client_phonenumber,
                                        s.device_sn,
                                        s.device_model,
                                        s.device_status,
                                        t.first_name,
                                        s.date_repair_completion,
                                        s.device_repaircost
                                        from device s
                                        inner join technic t on s.technic_id = t.technic_id
                                        ORDER BY s.date_receipt asc;";
                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {


                        adapter.Fill(dataTable);
                        if (dataTable.Columns["id"].ColumnName == "id")
                        {
                            dataTable.Columns["id"].ColumnName = "№_заказа";
                            dataTable.Columns["client_firstname"].ColumnName = "Имя клиента";
                            //dataTable.Columns["client_lastname"].ColumnName = "Фамилия клиента";
                            dataTable.Columns["client_phonenumber"].ColumnName = "Номер_клиента";
                            // dataTable.Columns["device"].ColumnName = "Техника";
                            //dataTable.Columns["device_brand"].ColumnName = "Бренд";
                            dataTable.Columns["device_model"].ColumnName = "Модель";
                            dataTable.Columns["device_sn"].ColumnName = "Серийный_номер";
                            dataTable.Columns["first_name"].ColumnName = "Мастер";
                            dataTable.Columns["date_receipt"].ColumnName = "Дата принятии заказа";
                            dataTable.Columns["device_status"].ColumnName = "Статус_ремонта";
                            dataTable.Columns["date_repair_completion"].ColumnName = "Дата завершения ремонта";
                            dataTable.Columns["device_repaircost"].ColumnName = "Стоимость ремонта";
                            dataTable.AcceptChanges();
                        }
                        adapter.Update(dataTable);
                        homeDataGridView.DataSource = dataTable;
                        homeDataGridView.BackgroundColor = Color.White;
                    }
                }
                DataView dataView = dataTable.DefaultView;
                orderResultLabel.Text = $"Заказов: {dataView.Count}";
            }
        }

        private void filterByTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            string filterExpression = string.Empty;
            if (filterByCombobox.Text == "Номер_клиента" && !string.IsNullOrEmpty(filterByTextBox.Text))
            {
                filterExpression += $"Номер_клиента like '%{filterByTextBox.Text}%' and ";

                if(!string.IsNullOrEmpty(deviceStatusFilterCombobox.Text))
                {
                    filterExpression += $"Статус_ремонта like '%{deviceStatusFilterCombobox.Text}%'";
                }
                if(filterExpression.EndsWith("and "))
                {
                    filterExpression = filterExpression.Substring(0, filterExpression.Length - 4);
                }
                
                dataView.RowFilter = filterExpression;
                orderResultLabel.Text = $"Заказов: {dataView.Count}";
            }
            if (filterByCombobox.Text == "Серийный_номер" && !string.IsNullOrEmpty(filterByTextBox.Text))
            {
                filterExpression += $"Серийный_номер like '%{filterByTextBox.Text}%' and ";

                if (!string.IsNullOrEmpty(deviceStatusFilterCombobox.Text))
                {
                    filterExpression += $"Статус_ремонта like '%{deviceStatusFilterCombobox.Text}%'";
                }
                if (filterExpression.EndsWith("and "))
                {
                    filterExpression = filterExpression.Substring(0, filterExpression.Length - 4);
                }

                dataView.RowFilter = filterExpression;
                orderResultLabel.Text = $"Заказов: {dataView.Count}";
            }




            if (filterByCombobox.Text == "№_заказа")
            {
                string draft = filterByCombobox.Text;
                if (filterByTextBox.Text != string.Empty)
                {

                    int temp = Int32.Parse(filterByTextBox.Text);
                    dataView.RowFilter = $"{draft} = {temp}";

                }
                orderResultLabel.Text = $"Заказов: {dataView.Count}";
            }

        }

        private void deviceStatusFilterCombobox_Click(object sender, EventArgs e)
        {
            if (!statusDataLoaded)
            {

                using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
                {
                    conn.Open();
                    string cmdText = "select * from deviceStatus";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string temp = reader["status"].ToString();
                                deviceStatusFilterCombobox.Items.Add(temp);
                            }
                            statusDataLoaded = true;
                        }

                    }
                    conn.Close();
                }
            }
        }

        private void deviceStatusFilterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            string filterExpression = string.Empty;
            if (filterByCombobox.Text == "Номер_клиента" && !string.IsNullOrEmpty(filterByTextBox.Text))
            {
                filterExpression += $"Номер_клиента like '%{filterByTextBox.Text}%' and ";

                if (!string.IsNullOrEmpty(deviceStatusFilterCombobox.Text))
                {
                    filterExpression += $"Статус_ремонта like '%{deviceStatusFilterCombobox.Text}%'";
                }
                if (filterExpression.EndsWith("and "))
                {
                    filterExpression = filterExpression.Substring(0, filterExpression.Length - 4);
                }
            }

            if (filterByCombobox.Text == "Серийный_номер" && !string.IsNullOrEmpty(filterByTextBox.Text))
            {
                filterExpression += $"Серийный_номер like '%{filterByTextBox.Text}%' and ";

                if (!string.IsNullOrEmpty(deviceStatusFilterCombobox.Text))
                {
                    filterExpression += $"Статус_ремонта like '%{deviceStatusFilterCombobox.Text}%'";
                }
                if (filterExpression.EndsWith("and "))
                {
                    filterExpression = filterExpression.Substring(0, filterExpression.Length - 4);
                }
            }
            if (string.IsNullOrEmpty(filterByCombobox.Text))
            {
                filterExpression += $"Статус_ремонта like '%{deviceStatusFilterCombobox.Text}%'";
            }



            dataView.RowFilter = filterExpression;
            orderResultLabel.Text = $"Заказов: {dataView.Count}";
        }


        private void AddOrderHome_Click(object sender, EventArgs e)
        {
            AddOrderButton addOrderButton = new AddOrderButton();
            addOrderButton.ShowDialog();
        }

        private void homeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? CurrentRow = Convert.ToInt32(homeDataGridView.CurrentCell.Value.ToString());
            if (CurrentRow != null)
            {
                Form2 form = new Form2(Convert.ToInt32(CurrentRow));
                form.ShowDialog();
            }
            else
                MessageBox.Show("Ошибка при выборе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
