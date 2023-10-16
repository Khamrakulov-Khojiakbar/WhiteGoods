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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.technicPage = new System.Windows.Forms.TabPage();
            this.technicsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstTab = new System.Windows.Forms.TabControl();
            this.masterDeleteBtn = new System.Windows.Forms.Button();
            this.masterEditBtn = new System.Windows.Forms.Button();
            this.masterCreateBtn = new System.Windows.Forms.Button();
            this.technicPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.firstTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // firstTab
            // 
            this.firstTab.Controls.Add(this.technicPage);
            this.firstTab.Controls.Add(this.tabPage2);
            this.firstTab.Controls.Add(this.tabPage3);
            this.firstTab.Controls.Add(this.tabPage4);
            this.firstTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstTab.Location = new System.Drawing.Point(0, 0);
            this.firstTab.Name = "firstTab";
            this.firstTab.SelectedIndex = 0;
            this.firstTab.Size = new System.Drawing.Size(800, 450);
            this.firstTab.TabIndex = 0;
            // 
            // masterDeleteBtn
            // 
            this.masterDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterDeleteBtn.Location = new System.Drawing.Point(410, 19);
            this.masterDeleteBtn.Name = "masterDeleteBtn";
            this.masterDeleteBtn.Size = new System.Drawing.Size(90, 30);
            this.masterDeleteBtn.TabIndex = 0;
            this.masterDeleteBtn.Text = "Delete";
            this.masterDeleteBtn.UseVisualStyleBackColor = true;
            this.masterDeleteBtn.Click += new System.EventHandler(this.masterDeleteBtn_Click);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstTab);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.technicPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.technicsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.firstTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage technicPage;
        private System.Windows.Forms.DataGridView technicsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl firstTab;
        private System.Windows.Forms.Button masterCreateBtn;
        private System.Windows.Forms.Button masterEditBtn;
        private System.Windows.Forms.Button masterDeleteBtn;
    }
}