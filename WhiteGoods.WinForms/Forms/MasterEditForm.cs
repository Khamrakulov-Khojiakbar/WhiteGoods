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

namespace WhiteGoods.WinForms.Forms
{
    public partial class MasterEditForm : Form
    {
        private int currentMaster;
        private readonly string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";
        public MasterEditForm()
        {
            InitializeComponent();
        }
        public MasterEditForm(int id)
        {
            InitializeComponent();
            FillTextBoxes(id);
            currentMaster = id;
        }

        private void FillTextBoxes(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"select * from technic where technic_id = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();

                            masterNameTxt.Text = reader["first_name"].ToString();
                            masterLastNameTxt.Text = reader["last_name"].ToString();
                            masterPhoneNumberTxt.Text = reader["phone_number"].ToString();

                            is_deletedChechBox.Checked = bool.Parse(reader["is_deleted"].ToString());
                            is_selected.Checked = bool.Parse(reader["is_selected"].ToString());
                        }
                    }
                
                }

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();
                string cmdText = @"update technic set first_name = @firstName, last_name = @lastName, phone_number = @number, is_selected = @isSelect, is_deleted = @isDeleted where technic_id = @id";              

                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(cmdText, conn))
                {
                    npgsqlCommand.Parameters.AddWithValue("id", currentMaster);
                    npgsqlCommand.Parameters.AddWithValue("firstName", masterNameTxt.Text);
                    npgsqlCommand.Parameters.AddWithValue("lastName", masterLastNameTxt.Text);
                    npgsqlCommand.Parameters.AddWithValue("number", masterPhoneNumberTxt.Text);
                    npgsqlCommand.Parameters.AddWithValue("isSelect", is_selected.Checked);
                    npgsqlCommand.Parameters.AddWithValue("isDeleted", is_deletedChechBox.Checked);

                    npgsqlCommand.ExecuteNonQuery();
                }

            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
