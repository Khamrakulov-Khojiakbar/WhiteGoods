using Npgsql;
using System;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class statusEditForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        private readonly string statusTemp;
        public statusEditForm()
        {
            InitializeComponent();
        }
        public statusEditForm(string name)
        {
            InitializeComponent();
            FillTextBox(name);
            statusTemp = name;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"update devicestatus set status = @name where status = @statusName";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("statusName", statusTemp);
                    cmd.Parameters.AddWithValue("name", statusTxt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно обновлены", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void FillTextBox(string name)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdTxt = @"select * from devicestatus where status = @name";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdTxt, conn))
                {
                    cmd.Parameters.AddWithValue("name", name);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            statusTxt.Text = reader["status"].ToString();
                        }
                    }
                }
            }
        }
    }
}
