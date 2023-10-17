using Npgsql;
using System;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class deviceEditForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        private readonly string deviceTypeTemp;
        public deviceEditForm()
        {
            InitializeComponent();
        }
        public deviceEditForm(string deviceType)
        {
            InitializeComponent();
            FillTextBox(deviceType);
            deviceTypeTemp = deviceType;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"update devicetype set devicetype = @name where devicetype = @deviceName";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("deviceName", deviceTypeTemp);
                    cmd.Parameters.AddWithValue("name", devicetypeTxt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно обновлены", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTextBox(string deviceType)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdTxt = @"select * from devicetype where devicetype = @device";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdTxt, conn))
                {
                    cmd.Parameters.AddWithValue("device", deviceType);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            devicetypeTxt.Text = reader["devicetype"].ToString();
                        }
                    }
                }
            }
        }
    }
}
