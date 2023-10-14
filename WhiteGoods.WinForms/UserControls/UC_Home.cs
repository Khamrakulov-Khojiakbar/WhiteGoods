using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.UserControls
{
    public partial class UC_Home : UserControl
    {
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";

        public UC_Home()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.OpenAsync();

                string cmdText = @"select 
                                         s.id,
                                         s.client_firstname, s.client_phonenumber,s.device_brand,s.device_model,s.device_sn,
                                         t.first_name, t.last_name as technic_name,
										 s.date_receipt
                                         from device s
                                         inner join technic t on s.technic_id = t.technic_id;";
                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        guna2DataGridView1.DataSource = dataTable;
                    }
                }
            }

        }
        private void LoadDataIntoDataGridView()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"select 
                                         s.id,
                                         s.client_firstname, s.client_phonenumber,s.device_brand,s.device_model,s.device_sn,
                                         t.first_name, t.last_name as technic_name,
										 s.date_receipt
                                         from device s
                                         inner join technic t on s.technic_id = t.technic_id;";
                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        guna2DataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

    }
}
