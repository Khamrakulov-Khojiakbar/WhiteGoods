namespace WhiteGoods.WinForms.Forms
{
    partial class brandCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.brandSaveBtn = new System.Windows.Forms.Button();
            this.brandCancelBtn = new System.Windows.Forms.Button();
            this.brandNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название бреда";
            // 
            // brandSaveBtn
            // 
            this.brandSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandSaveBtn.Location = new System.Drawing.Point(382, 408);
            this.brandSaveBtn.Name = "brandSaveBtn";
            this.brandSaveBtn.Size = new System.Drawing.Size(200, 30);
            this.brandSaveBtn.TabIndex = 1;
            this.brandSaveBtn.Text = "Save";
            this.brandSaveBtn.UseVisualStyleBackColor = true;
            this.brandSaveBtn.Click += new System.EventHandler(this.brandSaveBtn_Click);
            // 
            // brandCancelBtn
            // 
            this.brandCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandCancelBtn.Location = new System.Drawing.Point(588, 408);
            this.brandCancelBtn.Name = "brandCancelBtn";
            this.brandCancelBtn.Size = new System.Drawing.Size(200, 30);
            this.brandCancelBtn.TabIndex = 2;
            this.brandCancelBtn.Text = "Cancel";
            this.brandCancelBtn.UseVisualStyleBackColor = true;
            this.brandCancelBtn.Click += new System.EventHandler(this.brandCancelBtn_Click);
            // 
            // brandNameTxt
            // 
            this.brandNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandNameTxt.Location = new System.Drawing.Point(12, 54);
            this.brandNameTxt.Name = "brandNameTxt";
            this.brandNameTxt.Size = new System.Drawing.Size(291, 30);
            this.brandNameTxt.TabIndex = 3;
            // 
            // brandCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brandNameTxt);
            this.Controls.Add(this.brandCancelBtn);
            this.Controls.Add(this.brandSaveBtn);
            this.Controls.Add(this.label1);
            this.Name = "brandCreateForm";
            this.Text = "brandCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brandSaveBtn;
        private System.Windows.Forms.Button brandCancelBtn;
        private System.Windows.Forms.TextBox brandNameTxt;
    }
}