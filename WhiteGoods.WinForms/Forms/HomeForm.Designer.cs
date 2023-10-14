namespace WhiteGoods.WinForms.Forms
{
    partial class HomeForm
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
            this.homeDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddOrderHome = new System.Windows.Forms.Button();
            this.deviceStatusLabel = new System.Windows.Forms.Label();
            this.deviceStatusFilterCombobox = new System.Windows.Forms.ComboBox();
            this.orderResultLabel = new System.Windows.Forms.Label();
            this.filterByTextBox = new System.Windows.Forms.TextBox();
            this.filterByCombobox = new System.Windows.Forms.ComboBox();
            this.filterColumnName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeDataGridView
            // 
            this.homeDataGridView.AllowUserToAddRows = false;
            this.homeDataGridView.AllowUserToDeleteRows = false;
            this.homeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.homeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGridView.Location = new System.Drawing.Point(0, 81);
            this.homeDataGridView.Name = "homeDataGridView";
            this.homeDataGridView.ReadOnly = true;
            this.homeDataGridView.RowHeadersWidth = 51;
            this.homeDataGridView.RowTemplate.Height = 24;
            this.homeDataGridView.Size = new System.Drawing.Size(1348, 640);
            this.homeDataGridView.TabIndex = 2;
            this.homeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.homeDataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddOrderHome);
            this.panel1.Controls.Add(this.deviceStatusLabel);
            this.panel1.Controls.Add(this.deviceStatusFilterCombobox);
            this.panel1.Controls.Add(this.orderResultLabel);
            this.panel1.Controls.Add(this.filterByTextBox);
            this.panel1.Controls.Add(this.filterByCombobox);
            this.panel1.Controls.Add(this.filterColumnName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 83);
            this.panel1.TabIndex = 3;
            // 
            // AddOrderHome
            // 
            this.AddOrderHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrderHome.BackColor = System.Drawing.Color.LimeGreen;
            this.AddOrderHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderHome.ForeColor = System.Drawing.Color.White;
            this.AddOrderHome.Location = new System.Drawing.Point(1158, 14);
            this.AddOrderHome.Name = "AddOrderHome";
            this.AddOrderHome.Size = new System.Drawing.Size(178, 47);
            this.AddOrderHome.TabIndex = 6;
            this.AddOrderHome.Text = "Создать заказ";
            this.AddOrderHome.UseVisualStyleBackColor = false;
            this.AddOrderHome.Click += new System.EventHandler(this.AddOrderHome_Click);
            // 
            // deviceStatusLabel
            // 
            this.deviceStatusLabel.AutoSize = true;
            this.deviceStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceStatusLabel.Location = new System.Drawing.Point(329, 13);
            this.deviceStatusLabel.Name = "deviceStatusLabel";
            this.deviceStatusLabel.Size = new System.Drawing.Size(166, 25);
            this.deviceStatusLabel.TabIndex = 5;
            this.deviceStatusLabel.Text = "Статус ремонта";
            // 
            // deviceStatusFilterCombobox
            // 
            this.deviceStatusFilterCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceStatusFilterCombobox.FormattingEnabled = true;
            this.deviceStatusFilterCombobox.Location = new System.Drawing.Point(532, 14);
            this.deviceStatusFilterCombobox.Name = "deviceStatusFilterCombobox";
            this.deviceStatusFilterCombobox.Size = new System.Drawing.Size(181, 28);
            this.deviceStatusFilterCombobox.TabIndex = 4;
            this.deviceStatusFilterCombobox.SelectedIndexChanged += new System.EventHandler(this.deviceStatusFilterCombobox_SelectedIndexChanged);
            this.deviceStatusFilterCombobox.Click += new System.EventHandler(this.deviceStatusFilterCombobox_Click);
            // 
            // orderResultLabel
            // 
            this.orderResultLabel.AutoSize = true;
            this.orderResultLabel.Location = new System.Drawing.Point(746, 25);
            this.orderResultLabel.Name = "orderResultLabel";
            this.orderResultLabel.Size = new System.Drawing.Size(76, 16);
            this.orderResultLabel.TabIndex = 3;
            this.orderResultLabel.Text = "Заказов: 0";
            // 
            // filterByTextBox
            // 
            this.filterByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterByTextBox.Location = new System.Drawing.Point(120, 49);
            this.filterByTextBox.Name = "filterByTextBox";
            this.filterByTextBox.Size = new System.Drawing.Size(172, 26);
            this.filterByTextBox.TabIndex = 2;
            this.filterByTextBox.TextChanged += new System.EventHandler(this.filterByTextBox_TextChanged);
            // 
            // filterByCombobox
            // 
            this.filterByCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterByCombobox.FormattingEnabled = true;
            this.filterByCombobox.Items.AddRange(new object[] {
            "Номер_клиента",
            "№_заказа",
            "Серийный_номер"});
            this.filterByCombobox.Location = new System.Drawing.Point(120, 13);
            this.filterByCombobox.Name = "filterByCombobox";
            this.filterByCombobox.Size = new System.Drawing.Size(181, 28);
            this.filterByCombobox.TabIndex = 1;
            // 
            // filterColumnName
            // 
            this.filterColumnName.AutoSize = true;
            this.filterColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterColumnName.Location = new System.Drawing.Point(13, 12);
            this.filterColumnName.Name = "filterColumnName";
            this.filterColumnName.Size = new System.Drawing.Size(101, 25);
            this.filterColumnName.TabIndex = 0;
            this.filterColumnName.Text = "Поиск по:";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeDataGridView);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView homeDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filterByCombobox;
        private System.Windows.Forms.Label filterColumnName;
        private System.Windows.Forms.TextBox filterByTextBox;
        private System.Windows.Forms.Label orderResultLabel;
        private System.Windows.Forms.Label deviceStatusLabel;
        private System.Windows.Forms.ComboBox deviceStatusFilterCombobox;
        private System.Windows.Forms.Button AddOrderHome;
    }
}