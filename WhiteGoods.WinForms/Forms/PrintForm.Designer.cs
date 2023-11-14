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
            this.logo = new System.Windows.Forms.Label();
            this.DataGridDevicePrint = new System.Windows.Forms.DataGridView();
            this.PrintDataGridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.FirstRoleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDevicePrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FirstRoleLabel);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.DataGridDevicePrint);
            this.panel1.Controls.Add(this.PrintDataGridView);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Location = new System.Drawing.Point(-2, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 713);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.Location = new System.Drawing.Point(264, 1);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(198, 17);
            this.logo.TabIndex = 4;
            this.logo.Text = "Сервисный центр \"Телефон\"";
            // 
            // DataGridDevicePrint
            // 
            this.DataGridDevicePrint.BackgroundColor = System.Drawing.Color.White;
            this.DataGridDevicePrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDevicePrint.Location = new System.Drawing.Point(236, 76);
            this.DataGridDevicePrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridDevicePrint.Name = "DataGridDevicePrint";
            this.DataGridDevicePrint.RowHeadersWidth = 51;
            this.DataGridDevicePrint.RowTemplate.Height = 24;
            this.DataGridDevicePrint.Size = new System.Drawing.Size(229, 162);
            this.DataGridDevicePrint.TabIndex = 3;
            // 
            // PrintDataGridView
            // 
            this.PrintDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PrintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintDataGridView.Location = new System.Drawing.Point(2, 76);
            this.PrintDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrintDataGridView.Name = "PrintDataGridView";
            this.PrintDataGridView.RowHeadersWidth = 51;
            this.PrintDataGridView.RowTemplate.Height = 24;
            this.PrintDataGridView.Size = new System.Drawing.Size(229, 162);
            this.PrintDataGridView.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(158, 50);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(61, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Квитанция";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Chartreuse;
            this.printButton.Location = new System.Drawing.Point(386, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(220, 21);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(244, 13);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "г.  Ош ул. Аскар Шакирова 161 +996558022727";
            // 
            // FirstRoleLabel
            // 
            this.FirstRoleLabel.AutoSize = true;
            this.FirstRoleLabel.Location = new System.Drawing.Point(4, 244);
            this.FirstRoleLabel.Name = "FirstRoleLabel";
            this.FirstRoleLabel.Size = new System.Drawing.Size(1109, 13);
            this.FirstRoleLabel.TabIndex = 6;
            this.FirstRoleLabel.Text = "1. Сервисный Центр не несет ответсвенности за возможную потерю данных в индивидул" +
    "ьной памяти устройства, связанную с заменой плат, установкой программного обеспе" +
    "чения, заменой носителя информации.";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 774);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDevicePrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView PrintDataGridView;
        private System.Windows.Forms.DataGridView DataGridDevicePrint;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label FirstRoleLabel;
        private System.Windows.Forms.Label labelAddress;
    }
}