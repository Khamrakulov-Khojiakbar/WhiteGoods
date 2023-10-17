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
            FillDataBrand();
            FillDataStatuses();
            FillDataDevice();
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
            FillDataTechnic();
        }

        private void masterEditBtn_Click(object sender, EventArgs e)
        {
            int master = Convert.ToInt32(technicsDataGridView.CurrentCell.Value.ToString());
            MasterEditForm masterEdit = new MasterEditForm(master);
            masterEdit.ShowDialog();
            FillDataTechnic();
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

            FillDataTechnic();
        }

        private void FillDataBrand()
        {
            brandDataGridView.AllowUserToAddRows = false;

            using(NpgsqlConnection con = new NpgsqlConnection(_connection))
            {
                con.Open();

                string cmdTxt = @"select * from brands";

                using(NpgsqlCommand cmd = new NpgsqlCommand(cmdTxt, con)) 
                { 
                    using(NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        brandDataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void brandEditBtn_Click(object sender, EventArgs e)
        {
            string brandName = brandDataGridView.CurrentCell.Value.ToString();
            brandEditForm temp = new brandEditForm(brandName);
            temp.ShowDialog();
            FillDataBrand();
        }

        private void brandCreateBtn_Click(object sender, EventArgs e)
        {
            brandCreateForm brandCreateForm = new brandCreateForm();
            brandCreateForm.ShowDialog();
            FillDataBrand();
        }

        private void FillDataStatuses()
        {
            statusDataGridView.AllowUserToAddRows = false;

            using (NpgsqlConnection con = new NpgsqlConnection(_connection))
            {
                con.Open();

                string cmdTxt = @"select * from devicestatus";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdTxt, con))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        statusDataGridView.DataSource = dt;
                    }
                }
            }

        }

        private void statusCreateBtn_Click(object sender, EventArgs e)
        {
            statusCreateForm createForm = new statusCreateForm();
            createForm.ShowDialog();
            FillDataStatuses();
        }

        private void statusEditBtn_Click(object sender, EventArgs e)
        {
            string statusName = statusDataGridView.CurrentCell.Value.ToString();

            statusEditForm statusEditForm = new statusEditForm(statusName);
            statusEditForm.ShowDialog();
            FillDataStatuses();
        }


        private void FillDataDevice()
        {
            deviceDataGridView.AllowUserToAddRows = false;

            using (NpgsqlConnection con = new NpgsqlConnection(_connection))
            {
                con.Open();

                string cmdTxt = @"select * from devicetype";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdTxt, con))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        deviceDataGridView.DataSource = dt;
                    }
                }
            }
        }
        private void deviceEditBrn_Click(object sender, EventArgs e)
        {
            string deviceType = deviceDataGridView.CurrentCell.Value.ToString();

            deviceEditForm deviceEdit = new deviceEditForm(deviceType);
            deviceEdit.ShowDialog();
            FillDataDevice();
        }

        private void deviceCreateBtn_Click(object sender, EventArgs e)
        {
            deviceCreateForm deviceCreate = new deviceCreateForm();
            deviceCreate.ShowDialog();
            FillDataDevice();
        }
    }
}
