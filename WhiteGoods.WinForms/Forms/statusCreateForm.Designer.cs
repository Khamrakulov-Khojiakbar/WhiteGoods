namespace WhiteGoods.WinForms.Forms
{
    partial class statusCreateForm
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
            this.statusNameTxt = new System.Windows.Forms.TextBox();
            this.statusCancelBtn = new System.Windows.Forms.Button();
            this.statusSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusNameTxt
            // 
            this.statusNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusNameTxt.Location = new System.Drawing.Point(12, 47);
            this.statusNameTxt.Name = "statusNameTxt";
            this.statusNameTxt.Size = new System.Drawing.Size(291, 30);
            this.statusNameTxt.TabIndex = 7;
            // 
            // statusCancelBtn
            // 
            this.statusCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCancelBtn.Location = new System.Drawing.Point(588, 401);
            this.statusCancelBtn.Name = "statusCancelBtn";
            this.statusCancelBtn.Size = new System.Drawing.Size(200, 30);
            this.statusCancelBtn.TabIndex = 6;
            this.statusCancelBtn.Text = "Cancel";
            this.statusCancelBtn.UseVisualStyleBackColor = true;
            this.statusCancelBtn.Click += new System.EventHandler(this.statusCancelBtn_Click);
            // 
            // statusSaveBtn
            // 
            this.statusSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusSaveBtn.Location = new System.Drawing.Point(382, 401);
            this.statusSaveBtn.Name = "statusSaveBtn";
            this.statusSaveBtn.Size = new System.Drawing.Size(200, 30);
            this.statusSaveBtn.TabIndex = 5;
            this.statusSaveBtn.Text = "Save";
            this.statusSaveBtn.UseVisualStyleBackColor = true;
            this.statusSaveBtn.Click += new System.EventHandler(this.statusSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус";
            // 
            // statusCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusNameTxt);
            this.Controls.Add(this.statusCancelBtn);
            this.Controls.Add(this.statusSaveBtn);
            this.Controls.Add(this.label1);
            this.Name = "statusCreateForm";
            this.Text = "statusCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusNameTxt;
        private System.Windows.Forms.Button statusCancelBtn;
        private System.Windows.Forms.Button statusSaveBtn;
        private System.Windows.Forms.Label label1;
    }
}