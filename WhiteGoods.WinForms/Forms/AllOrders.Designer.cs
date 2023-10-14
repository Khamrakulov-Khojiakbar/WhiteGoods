namespace WhiteGoods.WinForms
{
    partial class AllOrdersForm
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
            this.dataGridAllOrders = new System.Windows.Forms.DataGridView();
            this.AddOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAllOrders
            // 
            this.dataGridAllOrders.AllowUserToAddRows = false;
            this.dataGridAllOrders.AllowUserToDeleteRows = false;
            this.dataGridAllOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAllOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllOrders.Location = new System.Drawing.Point(0, 56);
            this.dataGridAllOrders.Name = "dataGridAllOrders";
            this.dataGridAllOrders.ReadOnly = true;
            this.dataGridAllOrders.RowHeadersWidth = 51;
            this.dataGridAllOrders.RowTemplate.Height = 24;
            this.dataGridAllOrders.Size = new System.Drawing.Size(800, 394);
            this.dataGridAllOrders.TabIndex = 0;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrderButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.Location = new System.Drawing.Point(610, 3);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(178, 47);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Создать заказ";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // AllOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.dataGridAllOrders);
            this.Name = "AllOrdersForm";
            this.Text = "AllOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllOrders;
        private System.Windows.Forms.Button AddOrderButton;
    }
}