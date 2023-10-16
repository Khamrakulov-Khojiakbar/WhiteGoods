using Npgsql;
using System;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
     
    public partial class masterCreateForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public masterCreateForm()
        {
            InitializeComponent();
        }

        private void masterOkBtn_Click(object sender, EventArgs e)
        {
            using(NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdQuery = "Insert into technic (first_name, last_name, phone_number) VALUES (@masterName, @masterLastName, @masterPhone)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdQuery, conn))
                {
                    if (!string.IsNullOrEmpty(masterLastNameTxt.Text))
                    {

                        cmd.Parameters.AddWithValue("@masterName", masterNameTxt.Text);
                        cmd.Parameters.AddWithValue("@masterLastName", masterLastNameTxt.Text);
                        cmd.Parameters.AddWithValue("@masterPhone", masterPhoneNumber.Text);

                        MessageBox.Show("Мастер успешно добавлен", "Добавление мастеров", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();


                        cmd.ExecuteNonQuery();
                    }
                    else
                        MessageBox.Show("Заполните все поля","", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void masterCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
