namespace WhiteGoods.WinForms
{
    partial class AnalogForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.viewerBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelManager = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.viewerBtn);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.SettingsBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1348, 60);
            this.panelMenu.TabIndex = 0;
            // 
            // viewerBtn
            // 
            this.viewerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.viewerBtn.FlatAppearance.BorderSize = 0;
            this.viewerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewerBtn.Location = new System.Drawing.Point(81, 0);
            this.viewerBtn.Name = "viewerBtn";
            this.viewerBtn.Size = new System.Drawing.Size(150, 60);
            this.viewerBtn.TabIndex = 5;
            this.viewerBtn.Text = "Главная";
            this.viewerBtn.UseVisualStyleBackColor = false;
            this.viewerBtn.Click += new System.EventHandler(this.viewerBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(393, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "Информация";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.Location = new System.Drawing.Point(237, 0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(150, 60);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Настройки";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(75, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // panelManager
            // 
            this.panelManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManager.Location = new System.Drawing.Point(0, 60);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(1348, 661);
            this.panelManager.TabIndex = 1;
            this.panelManager.DoubleClick += new System.EventHandler(this.panelManager_DoubleClick);
            // 
            // AnalogForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panelManager);
            this.Controls.Add(this.panelMenu);
            this.Name = "AnalogForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalogForm3";
            this.Load += new System.EventHandler(this.AnalogForm3_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.Button viewerBtn;
    }
}