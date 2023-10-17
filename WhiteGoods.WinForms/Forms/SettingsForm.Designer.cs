namespace WhiteGoods.WinForms.Forms
{
    partial class SettingsForm
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deviceDataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deviceCreateBtn = new System.Windows.Forms.Button();
            this.deviceEditBrn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusCreateBtn = new System.Windows.Forms.Button();
            this.statusEditBtn = new System.Windows.Forms.Button();
            this.brands = new System.Windows.Forms.TabPage();
            this.brandDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brandCreateBtn = new System.Windows.Forms.Button();
            this.brandEditBtn = new System.Windows.Forms.Button();
            this.technicPage = new System.Windows.Forms.TabPage();
            this.technicsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.masterCreateBtn = new System.Windows.Forms.Button();
            this.masterEditBtn = new System.Windows.Forms.Button();
            this.masterDeleteBtn = new System.Windows.Forms.Button();
            this.firstTab = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.brands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.technicPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.firstTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deviceDataGridView);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Техника";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deviceDataGridView
            // 
            this.deviceDataGridView.AllowUserToAddRows = false;
            this.deviceDataGridView.AllowUserToDeleteRows = false;
            this.deviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.deviceDataGridView.Name = "deviceDataGridView";
            this.deviceDataGridView.ReadOnly = true;
            this.deviceDataGridView.RowHeadersWidth = 51;
            this.deviceDataGridView.RowTemplate.Height = 24;
            this.deviceDataGridView.Size = new System.Drawing.Size(786, 357);
            this.deviceDataGridView.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deviceCreateBtn);
            this.panel4.Controls.Add(this.deviceEditBrn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 58);
            this.panel4.TabIndex = 4;
            // 
            // deviceCreateBtn
            // 
            this.deviceCreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceCreateBtn.Location = new System.Drawing.Point(677, 19);
            this.deviceCreateBtn.Name = "deviceCreateBtn";
            this.deviceCreateBtn.Size = new System.Drawing.Size(90, 30);
            this.deviceCreateBtn.TabIndex = 2;
            this.deviceCreateBtn.Text = "Create";
            this.deviceCreateBtn.UseVisualStyleBackColor = true;
            this.deviceCreateBtn.Click += new System.EventHandler(this.deviceCreateBtn_Click);
            // 
            // deviceEditBrn
            // 
            this.deviceEditBrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceEditBrn.Location = new System.Drawing.Point(552, 19);
            this.deviceEditBrn.Name = "deviceEditBrn";
            this.deviceEditBrn.Size = new System.Drawing.Size(90, 30);
            this.deviceEditBrn.TabIndex = 1;
            this.deviceEditBrn.Text = "Edit";
            this.deviceEditBrn.UseVisualStyleBackColor = true;
            this.deviceEditBrn.Click += new System.EventHandler(this.deviceEditBrn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.statusDataGridView);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статусы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AllowUserToAddRows = false;
            this.statusDataGridView.AllowUserToDeleteRows = false;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDataGridView.Location = new System.Drawing.Point(3, 3);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.ReadOnly = true;
            this.statusDataGridView.RowHeadersWidth = 51;
            this.statusDataGridView.RowTemplate.Height = 24;
            this.statusDataGridView.Size = new System.Drawing.Size(786, 357);
            this.statusDataGridView.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusCreateBtn);
            this.panel3.Controls.Add(this.statusEditBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 58);
            this.panel3.TabIndex = 2;
            // 
            // statusCreateBtn
            // 
            this.statusCreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCreateBtn.Location = new System.Drawing.Point(677, 19);
            this.statusCreateBtn.Name = "statusCreateBtn";
            this.statusCreateBtn.Size = new System.Drawing.Size(90, 30);
            this.statusCreateBtn.TabIndex = 2;
            this.statusCreateBtn.Text = "Create";
            this.statusCreateBtn.UseVisualStyleBackColor = true;
            this.statusCreateBtn.Click += new System.EventHandler(this.statusCreateBtn_Click);
            // 
            // statusEditBtn
            // 
            this.statusEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusEditBtn.Location = new System.Drawing.Point(552, 19);
            this.statusEditBtn.Name = "statusEditBtn";
            this.statusEditBtn.Size = new System.Drawing.Size(90, 30);
            this.statusEditBtn.TabIndex = 1;
            this.statusEditBtn.Text = "Edit";
            this.statusEditBtn.UseVisualStyleBackColor = true;
            this.statusEditBtn.Click += new System.EventHandler(this.statusEditBtn_Click);
            // 
            // brands
            // 
            this.brands.Controls.Add(this.brandDataGridView);
            this.brands.Controls.Add(this.panel2);
            this.brands.Location = new System.Drawing.Point(4, 25);
            this.brands.Name = "brands";
            this.brands.Padding = new System.Windows.Forms.Padding(3);
            this.brands.Size = new System.Drawing.Size(792, 421);
            this.brands.TabIndex = 1;
            this.brands.Text = "Бренды";
            this.brands.UseVisualStyleBackColor = true;
            // 
            // brandDataGridView
            // 
            this.brandDataGridView.AllowUserToAddRows = false;
            this.brandDataGridView.AllowUserToDeleteRows = false;
            this.brandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandDataGridView.Location = new System.Drawing.Point(3, 3);
            this.brandDataGridView.Name = "brandDataGridView";
            this.brandDataGridView.ReadOnly = true;
            this.brandDataGridView.RowHeadersWidth = 51;
            this.brandDataGridView.RowTemplate.Height = 24;
            this.brandDataGridView.Size = new System.Drawing.Size(786, 357);
            this.brandDataGridView.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.brandCreateBtn);
            this.panel2.Controls.Add(this.brandEditBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 58);
            this.panel2.TabIndex = 2;
            // 
            // brandCreateBtn
            // 
            this.brandCreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandCreateBtn.Location = new System.Drawing.Point(677, 19);
            this.brandCreateBtn.Name = "brandCreateBtn";
            this.brandCreateBtn.Size = new System.Drawing.Size(90, 30);
            this.brandCreateBtn.TabIndex = 2;
            this.brandCreateBtn.Text = "Create";
            this.brandCreateBtn.UseVisualStyleBackColor = true;
            this.brandCreateBtn.Click += new System.EventHandler(this.brandCreateBtn_Click);
            // 
            // brandEditBtn
            // 
            this.brandEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandEditBtn.Location = new System.Drawing.Point(552, 19);
            this.brandEditBtn.Name = "brandEditBtn";
            this.brandEditBtn.Size = new System.Drawing.Size(90, 30);
            this.brandEditBtn.TabIndex = 1;
            this.brandEditBtn.Text = "Edit";
            this.brandEditBtn.UseVisualStyleBackColor = true;
            this.brandEditBtn.Click += new System.EventHandler(this.brandEditBtn_Click);
            // 
            // technicPage
            // 
            this.technicPage.Controls.Add(this.technicsDataGridView);
            this.technicPage.Controls.Add(this.panel1);
            this.technicPage.Location = new System.Drawing.Point(4, 25);
            this.technicPage.Name = "technicPage";
            this.technicPage.Padding = new System.Windows.Forms.Padding(3);
            this.technicPage.Size = new System.Drawing.Size(792, 421);
            this.technicPage.TabIndex = 0;
            this.technicPage.Text = "Мастер";
            this.technicPage.UseVisualStyleBackColor = true;
            // 
            // technicsDataGridView
            // 
            this.technicsDataGridView.AllowUserToAddRows = false;
            this.technicsDataGridView.AllowUserToDeleteRows = false;
            this.technicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.technicsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.technicsDataGridView.Name = "technicsDataGridView";
            this.technicsDataGridView.ReadOnly = true;
            this.technicsDataGridView.RowHeadersWidth = 51;
            this.technicsDataGridView.RowTemplate.Height = 24;
            this.technicsDataGridView.Size = new System.Drawing.Size(786, 357);
            this.technicsDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.masterCreateBtn);
            this.panel1.Controls.Add(this.masterEditBtn);
            this.panel1.Controls.Add(this.masterDeleteBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 58);
            this.panel1.TabIndex = 0;
            // 
            // masterCreateBtn
            // 
            this.masterCreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterCreateBtn.Location = new System.Drawing.Point(677, 19);
            this.masterCreateBtn.Name = "masterCreateBtn";
            this.masterCreateBtn.Size = new System.Drawing.Size(90, 30);
            this.masterCreateBtn.TabIndex = 2;
            this.masterCreateBtn.Text = "Create";
            this.masterCreateBtn.UseVisualStyleBackColor = true;
            this.masterCreateBtn.Click += new System.EventHandler(this.masterCreateBtn_Click);
            // 
            // masterEditBtn
            // 
            this.masterEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterEditBtn.Location = new System.Drawing.Point(552, 19);
            this.masterEditBtn.Name = "masterEditBtn";
            this.masterEditBtn.Size = new System.Drawing.Size(90, 30);
            this.masterEditBtn.TabIndex = 1;
            this.masterEditBtn.Text = "Edit";
            this.masterEditBtn.UseVisualStyleBackColor = true;
            this.masterEditBtn.Click += new System.EventHandler(this.masterEditBtn_Click);
            // 
            // masterDeleteBtn
            // 
            this.masterDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterDeleteBtn.Location = new System.Drawing.Point(423, 19);
            this.masterDeleteBtn.Name = "masterDeleteBtn";
            this.masterDeleteBtn.Size = new System.Drawing.Size(90, 30);
            this.masterDeleteBtn.TabIndex = 0;
            this.masterDeleteBtn.Text = "Delete";
            this.masterDeleteBtn.UseVisualStyleBackColor = true;
            this.masterDeleteBtn.Click += new System.EventHandler(this.masterDeleteBtn_Click);
            // 
            // firstTab
            // 
            this.firstTab.Controls.Add(this.technicPage);
            this.firstTab.Controls.Add(this.brands);
            this.firstTab.Controls.Add(this.tabPage3);
            this.firstTab.Controls.Add(this.tabPage4);
            this.firstTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstTab.Location = new System.Drawing.Point(0, 0);
            this.firstTab.Name = "firstTab";
            this.firstTab.SelectedIndex = 0;
            this.firstTab.Size = new System.Drawing.Size(800, 450);
            this.firstTab.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstTab);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.brands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.technicPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.technicsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.firstTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage brands;
        private System.Windows.Forms.TabPage technicPage;
        private System.Windows.Forms.DataGridView technicsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl firstTab;
        private System.Windows.Forms.Button masterCreateBtn;
        private System.Windows.Forms.Button masterEditBtn;
        private System.Windows.Forms.Button masterDeleteBtn;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button statusCreateBtn;
        private System.Windows.Forms.Button statusEditBtn;
        private System.Windows.Forms.DataGridView brandDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button brandCreateBtn;
        private System.Windows.Forms.Button brandEditBtn;
        private System.Windows.Forms.DataGridView deviceDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deviceCreateBtn;
        private System.Windows.Forms.Button deviceEditBrn;
    }
}