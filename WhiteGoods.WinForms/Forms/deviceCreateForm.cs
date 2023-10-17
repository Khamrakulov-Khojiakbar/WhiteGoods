using Npgsql;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class deviceCreateForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public deviceCreateForm()
        {
            InitializeComponent();
        }

        private void deviceSaveBtn_Click(object sender, System.EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"insert into devicetype (devicetype) values(@type) ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    if (!string.IsNullOrEmpty(deviceTypeNameTxt.Text))
                    {
                        cmd.Parameters.AddWithValue("type", deviceTypeNameTxt.Text);

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

        private void deviceCancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
