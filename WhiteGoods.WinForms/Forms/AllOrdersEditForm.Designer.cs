namespace WhiteGoods.WinForms.Forms
{
    partial class AllOrdersEditForm
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAllOrders
            // 
            this.dataGridAllOrders.AllowUserToAddRows = false;
            this.dataGridAllOrders.AllowUserToDeleteRows = false;
            this.dataGridAllOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAllOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridAllOrders.Name = "dataGridAllOrders";
            this.dataGridAllOrders.ReadOnly = true;
            this.dataGridAllOrders.RowHeadersWidth = 51;
            this.dataGridAllOrders.RowTemplate.Height = 24;
            this.dataGridAllOrders.Size = new System.Drawing.Size(800, 450);
            this.dataGridAllOrders.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(623, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllOrdersEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridAllOrders);
            this.Name = "AllOrdersEditForm";
            this.Text = "AllOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllOrders;
        private System.Windows.Forms.Button button1;
    }
}