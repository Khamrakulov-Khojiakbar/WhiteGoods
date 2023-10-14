using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WhiteGoods.WinForms.UserControls;

namespace WhiteGoods.WinForms
{
    public partial class Form2 : Form
    {
        private bool statusDataLoaded = false;
        private bool statusDeviceLoaded = false;
        private bool whichDeviceSelect = false;
        private int rowId = 0;
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int id)
        {
            rowId = id;
            InitializeComponent();
            FillTextboxes1(id);
        }

        public void FillTextboxes(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"select * from device where id = @id;";

                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {
                    command.Parameters.AddWithValue("id", id);


                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmdText, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            string dataToShow = "Данные из PostgreSQL:\n";

                            foreach (DataRow row in dataTable.Rows)
                            {
                                dataToShow += $"ID: {row["id"]}, " +
                                   $"Имя: {row["client_firstname"]}, " +
                                   $"Фамилия: {row["client_lastname"]}, " +
                                   $"Телефон: {row["client_phonenumber"]}, " +
                                   $"Адрес: {row["client_address"]}, " +
                                   $"Устройство: {row["device"]}, " +
                                   $"Бренд: {row["device_brand"]}, " +
                                   $"Модель: {row["device_model"]}, " +
                                   $"S/N: {row["device_sn"]}, " +
                                   $"Причина: {row["device_cause"]}, " +
                                   $"Комментарий: {row["device_comment"]}, " +
                                   $"Technic ID: {row["technic_id"]}\n";
                            }

                            MessageBox.Show(dataToShow, "Данные из PostgreSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Нет данных для отображения.", "Данные из PostgreSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
        }

        public void FillTextboxes1(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"select * from device where id = @id;";

                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {
                    command.Parameters.AddWithValue("id", id);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            client_name.Text = reader["client_firstname"].ToString();
                            client_lastname.Text = reader["client_lastname"].ToString();
                            client_phonenumber.Text = reader["client_phonenumber"].ToString();
                            client_address.Text = reader["client_address"].ToString();
                            whichDeviceCombobox.Text = reader["device"].ToString();
                            brandCombobox.Text = reader["device_brand"].ToString();
                            devicemodelTXB.Text = reader["device_model"].ToString();
                            deviceSNTXB.Text = reader["device_sn"].ToString();
                            deviceCause.Text = reader["device_cause"].ToString();
                            deviceStatus.Text = reader["device_status"].ToString();
                            deviceRepairConst.Text = reader["device_repaircost"].ToString() + " сом";
                            Comment.Text = reader["device_comment"].ToString();
                            DateTime dt = DateTime.Parse(reader["date_receipt"].ToString());
                            deviceRepairCompletedata.SelectionStart = dt;

                        }
                        else
                        {
                            MessageBox.Show("Нет данных для отображения.", "Данные из PostgreSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) && number != 8) || number == ' ')
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string som = " сом";
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 32)
            {
                e.Handled = true;
            }
            if (number == 13)
            {
                if (!deviceRepairConst.Text.Contains(som))
                {
                    deviceRepairConst.Text += som;
                }
            }
        }


        private void brandCombobox_Click(object sender, EventArgs e)
        {
            if (!statusDeviceLoaded)
            {

                using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
                {
                    conn.Open();
                    string cmdText = "select * from brands";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string temp = reader["brand"].ToString();
                                brandCombobox.Items.Add(temp);
                            }
                        }

                    }
                    conn.Close();
                }
            }
            statusDeviceLoaded = true;
        }

        private void deviceStatus_Click(object sender, EventArgs e)
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
                                deviceStatus.Items.Add(temp);
                            }
                        }

                    }
                    conn.Close();
                }
            }
            statusDataLoaded = true;
        }

        private void savebuttonTXT_Click(object sender, EventArgs e)
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(_connection))
            {
                connection.Open();
                string cmdText = $"update device set " +
                    $"client_firstname = @clientFirstName," +
                    $"client_lastname = @clientLastName," +
                    $"client_address = @clientAddress," +
                    $"client_phonenumber = @clientPhoneNumber," +
                    $"device = @device," +
                    $"device_brand = @deviceBrand," +
                    $"device_model = @deviceModel," +
                    $"device_sn = @deviceSn," +
                    $"device_cause = @deviceCause," +
                    $"device_comment = @deviceComment," +
                    $"device_repaircost = @deviceRepairCost," +
                    $"device_status = @deviceStatus, " +
                    $"date_repair_completion = @dataRepairCompletion" +
                    $" where id = {rowId};";

                using(NpgsqlCommand cmd = new NpgsqlCommand(cmdText, connection))
                {
                    DateTime date = DateTime.Parse(deviceRepairCompletedata.SelectionEnd.ToString());
                    string[] sum = deviceRepairConst.Text.Trim().Split(' ');
                    decimal repairCost = decimal.Parse(sum[0]);
                    cmd.Parameters.AddWithValue("clientFirstName", client_name.Text);
                    cmd.Parameters.AddWithValue("clientLastName", client_lastname.Text);
                    cmd.Parameters.AddWithValue("clientAddress", client_address.Text);
                    cmd.Parameters.AddWithValue("clientPhoneNumber", client_phonenumber.Text);
                    cmd.Parameters.AddWithValue("device", whichDeviceCombobox.Text);
                    cmd.Parameters.AddWithValue("deviceBrand", brandCombobox.Text);
                    cmd.Parameters.AddWithValue("deviceModel", devicemodelTXB.Text);
                    cmd.Parameters.AddWithValue("deviceSn", deviceSNTXB.Text);
                    cmd.Parameters.AddWithValue("deviceCause", deviceCause.Text);
                    cmd.Parameters.AddWithValue("deviceComment", Comment.Text);
                    cmd.Parameters.AddWithValue("deviceRepairCost", repairCost);
                    cmd.Parameters.AddWithValue("dataRepairCompletion", date);
                    cmd.Parameters.AddWithValue("deviceStatus", deviceStatus.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            
            this.Close();
            UC_add_device uc = new UC_add_device();
            uc.LoadDataIntoDataGridView();
        }

        private void whichDeviceCombobox_Click(object sender, EventArgs e)
        {
            if (!whichDeviceSelect)
            {

                using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
                {
                    conn.Open();
                    string cmdText = "select * from deviceType";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string temp = reader["deviceType"].ToString();
                                whichDeviceCombobox.Items.Add(temp);
                            }
                        }

                    }
                    conn.Close();
                }
            }
            whichDeviceSelect = true;
        }

        private void cancelButtonTXT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void devicemodelTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void deviceSNTXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
