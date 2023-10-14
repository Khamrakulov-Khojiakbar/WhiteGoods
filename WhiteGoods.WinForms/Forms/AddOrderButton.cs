using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class AddOrderButton : Form
    {
        //Fields

        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        private bool whichDeviceSelect = false;
        private bool statusDeviceLoaded = false;
        private bool statusDataLoaded = false;
        private int? selectedMaster = null;
        //Constructor
        public AddOrderButton()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        //Methods
        private void AddOrderButton_Load(object sender, EventArgs e)
        {
            clientBox_Leave(sender, e);
            clientLastNameText_Leave(sender, e);
            clientPhoneNumberText_Leave(sender, e);
            whichDeviceSelectCombobox_Leave(sender, e);
            brandCombobox_Leave(sender, e);
            deviceModel_Leave(sender, e);
            deviceSn_Leave(sender, e);
            clientAddressTextBox_Leave(sender, e);
            masterGetDataGridView_Enter(sender, e);


        }

        private void clientBox_Enter(object sender, EventArgs e)
        {
            if (clientNameBox.Text == "Имя клиента")
            {
                clientNameBox.Text = "";
                clientNameBox.ForeColor = Color.Black;
            }

        }

        private void clientBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientNameBox.Text))
            {
                clientNameBox.Text = "Имя клиента";
                clientNameBox.ForeColor = Color.Gray;
            }

        }

        private void clientLastNameText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientLastNameText.Text))
            {
                clientLastNameText.Text = "Фамилия клиента";
                clientLastNameText.ForeColor = Color.Gray;
            }
        }

        private void clientLastNameText_Enter(object sender, EventArgs e)
        {
            if (clientLastNameText.Text == "Фамилия клиента")
            {
                clientLastNameText.Text = "";
                clientLastNameText.ForeColor = Color.Black;
            }
        }

        private void clientPhoneNumberText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientPhoneNumberText.Text))
            {
                clientPhoneNumberText.Text = "Номер телефона";
                clientPhoneNumberText.ForeColor = Color.Gray;
            }
        }

        private void clientPhoneNumberText_Enter(object sender, EventArgs e)
        {
            if (clientPhoneNumberText.Text == "Номер телефона")
            {
                clientPhoneNumberText.Text = "";
                clientPhoneNumberText.ForeColor = Color.Black;
            }
        }


        private void whichDeviceSelectCombobox_Click(object sender, EventArgs e)
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
                                whichDeviceSelectCombobox.Items.Add(temp);
                            }
                        }

                    }
                    conn.Close();
                }
            }
            whichDeviceSelect = true;
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

        private void whichDeviceSelectCombobox_Enter(object sender, EventArgs e)
        {

            
            if (whichDeviceSelectCombobox.Text == "Техника")
            {
                whichDeviceSelectCombobox.Text = "";
                whichDeviceSelectCombobox.ForeColor = Color.Black;
            }
            if (whichDeviceSelectCombobox.Items.Count == 0)
            {
                technicChooseButton.Enabled = true;
            }

        }

        private void whichDeviceSelectCombobox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(whichDeviceSelectCombobox.Text))
            {
                whichDeviceSelectCombobox.Text = "Техника";
                whichDeviceSelectCombobox.ForeColor = Color.Gray;
            }
            if (whichDeviceSelectCombobox.Items.Count == 0)
            {
                technicChooseButton.Enabled = false;
            }
        }

        private void brandCombobox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(brandCombobox.Text))
            {
                brandCombobox.Text = "Брэнд";
                brandCombobox.ForeColor = Color.Gray;
            }
        }

        private void brandCombobox_Enter(object sender, EventArgs e)
        {
            if (brandCombobox.Text == "Брэнд")
            {
                brandCombobox.Text = "";
                brandCombobox.ForeColor = Color.Black;
            }
        }

        private void deviceModel_Enter(object sender, EventArgs e)
        {
            if (deviceModel.Text == "Модель")
            {
                deviceModel.Text = "";
                deviceModel.ForeColor = Color.Black;
            }
        }

        private void deviceModel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deviceModel.Text))
            {
                deviceModel.Text = "Модель";
                deviceModel.ForeColor = Color.Gray;
            }
        }

        private void deviceSn_Enter(object sender, EventArgs e)
        {
            if (deviceSn.Text == "Серийный номер")
            {
                deviceSn.Text = "";
                deviceSn.ForeColor = Color.Black;
            }
        }

        private void deviceSn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deviceSn.Text))
            {
                deviceSn.Text = "Серийный номер";
                deviceSn.ForeColor = Color.Gray;
            }
        }

        private void addButtonAddOrder_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string insertQuery = "INSERT INTO device (" +
                    "client_firstname, " +
                    "client_lastname," +
                    "client_phonenumber, " +
                    "client_address, " +
                    "device, " +
                    "device_brand, " +
                    "device_model, " +
                    "device_sn, " +
                    "device_cause, " +
                    "device_status, " +
                    "device_repaircost," +
                    "technic_id) " +
                "VALUES (" + // Данные для выполнения запроса на PostgreSql
                "@client_firstname, " +
                "@client_lastname, " +
                "@client_phonenumber, " +
                "@client_address, " +
                "@device, " +
                "@device_brand, " +
                "@device_model, " +
                "@device_sn, " +
                "@device_cause, " +
                "@device_status, " +
                "@device_repaircost," +
                "@technic_id)";

                NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn);
                {
                    if (selectedMaster != null)
                    {
                        cmd.Parameters.AddWithValue("@client_firstname", clientNameBox.Text);
                        cmd.Parameters.AddWithValue("@client_lastname", clientLastNameText.Text);
                        cmd.Parameters.AddWithValue("@client_phonenumber", clientPhoneNumberText.Text);
                        cmd.Parameters.AddWithValue("@client_address", clientAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@device", whichDeviceSelectCombobox.Text);
                        cmd.Parameters.AddWithValue("@device_brand", brandCombobox.Text);
                        cmd.Parameters.AddWithValue("@device_model", deviceModel.Text);
                        cmd.Parameters.AddWithValue("@device_sn", deviceSn.Text);
                        cmd.Parameters.AddWithValue("@device_cause", deviceCauseTextBox.Text);
                        cmd.Parameters.AddWithValue("@device_status", deviceStatusCombobox.Text);
                        cmd.Parameters.AddWithValue("@technic_id", selectedMaster);
                        cmd.Parameters.AddWithValue("@device_repaircost", 0);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Данные успешно добавлены", "Добавление записей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Выберите мастера", "Выбор мастера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void deviceStatusCombobox_Click(object sender, EventArgs e)
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
                                deviceStatusCombobox.Items.Add(temp);
                            }
                        }

                    }
                    conn.Close();
                }
            }
            statusDataLoaded = true;
        }

        private void clientAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientAddressTextBox.Text))
            {
                clientAddressTextBox.Text = "Адрес клиента";
                clientAddressTextBox.ForeColor = Color.Gray;
            }
        }

        private void clientAddressTextBox_Enter(object sender, EventArgs e)
        {
            if (clientAddressTextBox.Text == "Адрес клиента")
            {
                clientAddressTextBox.Text = "";
                clientAddressTextBox.ForeColor = Color.Black;
            }
        }


        private void masterGetDataGridView_Enter(object sender, EventArgs e)
        {
            masterGetDataGridView.AllowUserToAddRows = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"select technic_id, first_name from technic";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        masterGetDataGridView.DataSource = dataTable;
                    }
                }
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int currentMasterID = 0;
        private void LoadNextMasterButton_Click(object sender, EventArgs e)
        {

            if (whichDeviceSelectCombobox.Text == "Стиральная машина")
            {

                technicChooseButton.Enabled = true;
                using (NpgsqlConnection connection = new NpgsqlConnection(_connection))
                {

                    connection.Open();
                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM technic WHERE is_selected = false ORDER BY technic_id LIMIT 1", connection))
                            {

                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        currentMasterID = reader.GetInt32(0);
                                        selectedMaster = currentMasterID;
                                        string firstName = reader.GetString(1);
                                        string lastName = reader.GetString(2);
                                        connection.Close();
                                        // Отметить мастера как выбранного
                                        connection.Open();

                                        using (NpgsqlCommand updateCmd = new NpgsqlCommand("UPDATE technic SET is_selected = true WHERE technic_id = @MasterID", connection))
                                        {
                                            updateCmd.Parameters.AddWithValue("@MasterID", currentMasterID);
                                            updateCmd.ExecuteNonQuery();
                                        }

                                        MessageBox.Show($"Выбран мастер: {firstName} {lastName}");
                                        technicChooseButton.Enabled = false;
                                    }
                                    else
                                    {
                                        ReturnTechnicsFalse();

                                        MessageBox.Show("Все мастера уже выбраны.");
                                        LoadNextMasterButton_Click(sender, e);
                                    }
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex.Message}");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }

            }
            else
            {
                int row = Convert.ToInt32(masterGetDataGridView.CurrentCell.Value.ToString());
                using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
                {
                    conn.Open();
                    string cmdText = "select first_name from technic where technic_id = @row";
                    using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                    {
                        command.Parameters.AddWithValue("@row", row);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["first_name"].ToString();

                                MessageBox.Show($"Мастер:  {firstName}", "Выбранный мастер");
                                selectedMaster = row;
                            }
                            else
                            {
                                MessageBox.Show("Нет данных для выбранной строки.", "Выбранный мастер");
                            }


                        }
                    }

                }
            }
        }

        private void ReturnTechnicsFalse()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string sqlQuery = "update technic set is_selected = false;";

                using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        private void technicChooseButton_Click(object sender, EventArgs e)
        {
            LoadNextMasterButton_Click(sender, e);
        }

        private void clientPhoneNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) && number != 8) || number == ' ')
            {
                e.Handled = true;
            }
        }

        private void deviceModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void deviceSn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (!technicChooseButton.Enabled && selectedMaster != null)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
                {
                    conn.Open();
                    string cmdText = @"update technic set is_selected = false where technic_id = @currentMasterId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                    {
                        cmd.Parameters.AddWithValue("@currentMasterId", selectedMaster);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            this.Close();
        }
    }
}

