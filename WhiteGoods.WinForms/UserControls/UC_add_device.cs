using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.UserControls
{
    public partial class UC_add_device : UserControl
    {
        public string Form2Row = null;
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public UC_add_device()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        /*private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }*/

        public void LoadDataIntoDataGridView()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"select 
                                         s.id,
                                         s.client_firstname, 
                                         s.client_phonenumber,
                                         s.device,
                                         s.device_brand,
                                         s.device_model,
                                         s.device_sn,
                                         s.device_cause,
                                         s.device_comment,
                                         s.device_repaircost,
                                         s.date_receipt,
                                         s.date_repair_completion,
                                         s.device_status,
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

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private int row;
        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"select * from device where id = @id;";
                //row = dataGridView1.SelectedRows[0].Index + 1;
                row = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, conn))
                {

                    command.Parameters.AddWithValue("id", row);
                    
                    Form2 newform = new Form2(row);
                    newform.ShowDialog(); // Изменение данных клиента и техники
                    LoadDataIntoDataGridView(); // Обновление данных на DatagridView после сохранение данных
                }

            }



        }
    }
}
