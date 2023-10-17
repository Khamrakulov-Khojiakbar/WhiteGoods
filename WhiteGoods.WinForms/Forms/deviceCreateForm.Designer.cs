namespace WhiteGoods.WinForms.Forms
{
    partial class deviceCreateForm
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
            this.deviceTypeNameTxt = new System.Windows.Forms.TextBox();
            this.deviceCancelBtn = new System.Windows.Forms.Button();
            this.deviceSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deviceTypeNameTxt
            // 
            this.deviceTypeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceTypeNameTxt.Location = new System.Drawing.Point(12, 47);
            this.deviceTypeNameTxt.Name = "deviceTypeNameTxt";
            this.deviceTypeNameTxt.Size = new System.Drawing.Size(291, 30);
            this.deviceTypeNameTxt.TabIndex = 11;
            // 
            // deviceCancelBtn
            // 
            this.deviceCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceCancelBtn.Location = new System.Drawing.Point(588, 401);
            this.deviceCancelBtn.Name = "deviceCancelBtn";
            this.deviceCancelBtn.Size = new System.Drawing.Size(200, 30);
            this.deviceCancelBtn.TabIndex = 10;
            this.deviceCancelBtn.Text = "Cancel";
            this.deviceCancelBtn.UseVisualStyleBackColor = true;
            this.deviceCancelBtn.Click += new System.EventHandler(this.deviceCancelBtn_Click);
            // 
            // deviceSaveBtn
            // 
            this.deviceSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceSaveBtn.Location = new System.Drawing.Point(382, 401);
            this.deviceSaveBtn.Name = "deviceSaveBtn";
            this.deviceSaveBtn.Size = new System.Drawing.Size(200, 30);
            this.deviceSaveBtn.TabIndex = 9;
            this.deviceSaveBtn.Text = "Save";
            this.deviceSaveBtn.UseVisualStyleBackColor = true;
            this.deviceSaveBtn.Click += new System.EventHandler(this.deviceSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Техника";
            // 
            // deviceCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deviceTypeNameTxt);
            this.Controls.Add(this.deviceCancelBtn);
            this.Controls.Add(this.deviceSaveBtn);
            this.Controls.Add(this.label1);
            this.Name = "deviceCreateForm";
            this.Text = "deviceCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deviceTypeNameTxt;
        private System.Windows.Forms.Button deviceCancelBtn;
        private System.Windows.Forms.Button deviceSaveBtn;
        private System.Windows.Forms.Label label1;
    }
}