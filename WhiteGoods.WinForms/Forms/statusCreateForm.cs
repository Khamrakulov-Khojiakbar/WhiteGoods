using Npgsql;
using System;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class statusCreateForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public statusCreateForm()
        {
            InitializeComponent();
        }

        private void statusCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusSaveBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"insert into devicestatus (status) values(@status) ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    if (!string.IsNullOrEmpty(statusNameTxt.Text))
                    {
                        cmd.Parameters.AddWithValue("status", statusNameTxt.Text);

                        MessageBox.Show("Данные сохранены");

                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
