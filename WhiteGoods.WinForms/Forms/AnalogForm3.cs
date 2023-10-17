using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;
using WhiteGoods.WinForms.Forms;

namespace WhiteGoods.WinForms
{
    public partial class AnalogForm3 : Form
    {
        //Fields
        private Button currentButton;
        private Form activeForm;
        //Constructor
        public AnalogForm3()
        {
            InitializeComponent();
        }

        //Methods
        public void OpenChildPublic()
        {
            OpenChildFormToPanel(new AnalogForm3(), currentButton);
        }
        public void OpenChildFormToPanel(Form childF, object BtSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(BtSender);
            activeForm = childF;
            childF.TopLevel = false;
            childF.FormBorderStyle = FormBorderStyle.None;
            childF.Dock = DockStyle.Fill;
            this.panelManager.Controls.Add(childF);
            this.panelManager.Tag = childF;
            childF.BringToFront();
            childF.Show();
        }


        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = ColorTranslator.FromHtml("#0c4da2 "); //#4169E1;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font(
                        "Microsoft Sans Serif",
                        12.5F,
                        FontStyle.Regular,
                        GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font(
                        "Microsoft Sans Serif",
                        10F,
                        FontStyle.Regular,
                        GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildFormToPanel(new AllOrdersForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildFormToPanel(new AllOrdersEditForm(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentButton != (Button)sender)
            {
                ActiveButton(sender);
                using (var passwordForm = new PasswordForm())
                {
                    if (passwordForm.ShowDialog() == DialogResult.OK)
                    {
                        string enteredPassword = passwordForm.EnteredPassword;

                        if (enteredPassword == GetPassWordFromDB())
                        {
                            OpenChildFormToPanel(new SettingsForm(), sender);
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                    }
                }
            }
        }

        private string GetPassWordFromDB()
        {
            const string _connection = "Server=localhost; Port=5432; Database=service; User Id=postgres; Password=1221;";

            using (NpgsqlConnection conn = new NpgsqlConnection(_connection))
            {
                conn.Open();

                string cmdText = @"select * from WinFormsPassword";

                using (NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn))
                {
                    string password = cmd.ExecuteScalar().ToString();

                    return password;
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildFormToPanel(new InformationForm(), sender);
        }

        private void viewerBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormToPanel(new HomeForm(), sender);
        }

        private void AnalogForm3_Load(object sender, EventArgs e)
        {
            ClickPerform();
        }
        public void ClickPerform()
        {
            viewerBtn.PerformClick();
        }
        private void panelManager_DoubleClick(object sender, EventArgs e)
        {

        }

    }
}
