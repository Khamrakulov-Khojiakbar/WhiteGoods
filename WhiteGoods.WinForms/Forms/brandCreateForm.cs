using Npgsql;
using System;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class brandCreateForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public brandCreateForm()
        {
            InitializeComponent();
        }

        private void brandCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brandSaveBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"insert into brands (brand) values(@name) ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    if (!string.IsNullOrEmpty(brandNameTxt.Text))
                    {
                        cmd.Parameters.AddWithValue("name", brandNameTxt.Text);

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
