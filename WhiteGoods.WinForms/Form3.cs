using System;
using System.Windows.Forms;
using WhiteGoods.WinForms.UserControls;

namespace WhiteGoods.WinForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_add_device uc = new UC_add_device();
            addUserControl(uc);
        }
    }
}
