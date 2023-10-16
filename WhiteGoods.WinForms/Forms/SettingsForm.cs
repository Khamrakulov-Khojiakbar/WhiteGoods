using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{

    public partial class SettingsForm : Form
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";

        public SettingsForm()
        {
            InitializeComponent();
            FillDataTechnic();
        }
        private void FillDataTechnic()
        {
            technicsDataGridView.AllowUserToAddRows = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"select * from technic";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        technicsDataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void masterCreateBtn_Click(object sender, EventArgs e)
        {
            masterCreateForm masterCreate = new masterCreateForm();
            masterCreate.ShowDialog();
        }

        private void masterEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void masterDeleteBtn_Click(object sender, EventArgs e)
        {
            int? currentRow = Convert.ToInt32(technicsDataGridView.CurrentCell.Value.ToString());

            if (currentRow != null)
            {
                using(NpgsqlConnection conn = new NpgsqlConnection(_connection))
                {
                    conn.Open();
                    string cmdQuery = "update technic set is_deleted = true where technic_id = @masterId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(cmdQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@masterId", currentRow);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Мастер успешно удален");
                    }
                }
            }



        }
    }
}
