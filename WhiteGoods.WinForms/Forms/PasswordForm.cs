using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteGoods.WinForms.Forms
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            passwordTxtBox.UseSystemPasswordChar = true;
        }

        public string EnteredPassword { get; private set; }
        

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            EnteredPassword = passwordTxtBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
