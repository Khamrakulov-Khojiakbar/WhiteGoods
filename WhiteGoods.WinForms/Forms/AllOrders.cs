using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WhiteGoods.WinForms.Forms;

namespace WhiteGoods.WinForms
{
    public partial class AllOrdersForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        private int? CurrentRow = null;
        public AllOrdersForm()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }


        private void LoadDataIntoDataGridView()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"select 
                                         s.id,
                                         s.client_firstname,
                                         s.client_lastname,
                                         s.client_phonenumber,
                                         s.device,
                                         s.device_brand,
                                         s.device_model,
                                         s.device_sn,
                                         t.first_name,
										 s.date_receipt,
                                         s.device_status,
                                         s.date_repair_completion,
                                         s.device_repaircost
                                         from device s
                                         inner join technic t on s.technic_id = t.technic_id;";
                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        dataTable.Columns["id"].ColumnName = "№ заказа";
                        dataTable.Columns["client_firstname"].ColumnName = "Имя клиента";
                        dataTable.Columns["client_lastname"].ColumnName = "Фамилия клиента";
                        dataTable.Columns["client_phonenumber"].ColumnName = "Номер клиента";
                        dataTable.Columns["device"].ColumnName = "Техника";
                        dataTable.Columns["device_brand"].ColumnName = "Бренд";
                        dataTable.Columns["device_model"].ColumnName = "Модель";
                        dataTable.Columns["device_sn"].ColumnName = "Серийный номер";
                        dataTable.Columns["first_name"].ColumnName = "Мастер";
                        dataTable.Columns["date_receipt"].ColumnName = "Дата принятии заказа";
                        dataTable.Columns["device_status"].ColumnName = "Статус ремонта";
                        dataTable.Columns["date_repair_completion"].ColumnName = "Дата завершения ремонта";
                        dataTable.Columns["device_repaircost"].ColumnName = "Стоимость ремонта";
                        dataTable.AcceptChanges();

                        dataGridAllOrders.DataSource = dataTable;
                        dataGridAllOrders.BackgroundColor = Color.White;

                    }
                }
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {   
            AddOrderButton addOrderButton = new AddOrderButton();
            addOrderButton.ShowDialog();
            LoadDataIntoDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentRow = Convert.ToInt32(dataGridAllOrders.CurrentCell.Value.ToString());
            if (CurrentRow != null)
            {
                Form2 form = new Form2(Convert.ToInt32(CurrentRow));
                form.ShowDialog();
                LoadDataIntoDataGridView();
            }
            else
                MessageBox.Show("Ошибка при выборе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
