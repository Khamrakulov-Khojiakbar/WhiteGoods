namespace WhiteGoods.WinForms.Forms
{
    partial class PrintForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.PrintDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridDevicePrint = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDevicePrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clientNameLabel);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.DataGridDevicePrint);
            this.panel1.Controls.Add(this.PrintDataGridView);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 877);
            this.panel1.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(211, 62);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(77, 16);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Квитанция";
            // 
            // PrintDataGridView
            // 
            this.PrintDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PrintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintDataGridView.Location = new System.Drawing.Point(3, 94);
            this.PrintDataGridView.Name = "PrintDataGridView";
            this.PrintDataGridView.RowHeadersWidth = 51;
            this.PrintDataGridView.RowTemplate.Height = 24;
            this.PrintDataGridView.Size = new System.Drawing.Size(305, 200);
            this.PrintDataGridView.TabIndex = 2;
            // 
            // DataGridDevicePrint
            // 
            this.DataGridDevicePrint.BackgroundColor = System.Drawing.Color.White;
            this.DataGridDevicePrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDevicePrint.Location = new System.Drawing.Point(315, 94);
            this.DataGridDevicePrint.Name = "DataGridDevicePrint";
            this.DataGridDevicePrint.RowHeadersWidth = 51;
            this.DataGridDevicePrint.RowTemplate.Height = 24;
            this.DataGridDevicePrint.Size = new System.Drawing.Size(305, 200);
            this.DataGridDevicePrint.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Location = new System.Drawing.Point(412, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(195, 16);
            this.logo.TabIndex = 4;
            this.logo.Text = "Сервисный центр \"Телефон\"";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(53, 20);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(44, 16);
            this.clientNameLabel.TabIndex = 5;
            this.clientNameLabel.Text = "label1";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 953);
            this.Controls.Add(this.panel1);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDevicePrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView PrintDataGridView;
        private System.Windows.Forms.DataGridView DataGridDevicePrint;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label clientNameLabel;
    }
}