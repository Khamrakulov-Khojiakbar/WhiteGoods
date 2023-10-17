using Npgsql;
using System;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{

    public partial class brandEditForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        private readonly string tempBrandName;

        public brandEditForm()
        {
            InitializeComponent();
        }
        public brandEditForm(string name)
        {
            InitializeComponent();
            FillTextBox(name);
            tempBrandName = name;
        }
        private void FillTextBox(string name)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdTxt = @"select * from brands where brand = @name";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdTxt, conn))
                {
                    cmd.Parameters.AddWithValue("name", name);

                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();

                            brandTxt.Text = reader["brand"].ToString();
                        }
                    }
                }
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            using(NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"update brands set brand = @name where brand = @brandName";

                using(NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("brandName", tempBrandName);
                    cmd.Parameters.AddWithValue("name", brandTxt.Text);

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
    }
}
