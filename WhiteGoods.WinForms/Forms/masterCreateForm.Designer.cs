namespace WhiteGoods.WinForms.Forms
{
    partial class masterCreateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.masterNameTxt = new System.Windows.Forms.TextBox();
            this.masterLastNameTxt = new System.Windows.Forms.TextBox();
            this.masterPhoneNumber = new System.Windows.Forms.TextBox();
            this.masterOkBtn = new System.Windows.Forms.Button();
            this.masterCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя мастера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия мастера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефона";
            // 
            // masterNameTxt
            // 
            this.masterNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterNameTxt.Location = new System.Drawing.Point(17, 36);
            this.masterNameTxt.Name = "masterNameTxt";
            this.masterNameTxt.Size = new System.Drawing.Size(275, 26);
            this.masterNameTxt.TabIndex = 4;
            // 
            // masterLastNameTxt
            // 
            this.masterLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterLastNameTxt.Location = new System.Drawing.Point(17, 111);
            this.masterLastNameTxt.Name = "masterLastNameTxt";
            this.masterLastNameTxt.Size = new System.Drawing.Size(275, 26);
            this.masterLastNameTxt.TabIndex = 5;
            // 
            // masterPhoneNumber
            // 
            this.masterPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterPhoneNumber.Location = new System.Drawing.Point(16, 196);
            this.masterPhoneNumber.Name = "masterPhoneNumber";
            this.masterPhoneNumber.Size = new System.Drawing.Size(276, 26);
            this.masterPhoneNumber.TabIndex = 6;
            // 
            // masterOkBtn
            // 
            this.masterOkBtn.Location = new System.Drawing.Point(532, 403);
            this.masterOkBtn.Name = "masterOkBtn";
            this.masterOkBtn.Size = new System.Drawing.Size(110, 30);
            this.masterOkBtn.TabIndex = 7;
            this.masterOkBtn.Text = "Ok";
            this.masterOkBtn.UseVisualStyleBackColor = true;
            this.masterOkBtn.Click += new System.EventHandler(this.masterOkBtn_Click);
            // 
            // masterCancelBtn
            // 
            this.masterCancelBtn.Location = new System.Drawing.Point(666, 403);
            this.masterCancelBtn.Name = "masterCancelBtn";
            this.masterCancelBtn.Size = new System.Drawing.Size(110, 30);
            this.masterCancelBtn.TabIndex = 8;
            this.masterCancelBtn.Text = "Отмена";
            this.masterCancelBtn.UseVisualStyleBackColor = true;
            this.masterCancelBtn.Click += new System.EventHandler(this.masterCancelBtn_Click);
            // 
            // masterCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.masterCancelBtn);
            this.Controls.Add(this.masterOkBtn);
            this.Controls.Add(this.masterPhoneNumber);
            this.Controls.Add(this.masterLastNameTxt);
            this.Controls.Add(this.masterNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "masterCreateForm";
            this.Text = "masterCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox masterNameTxt;
        private System.Windows.Forms.TextBox masterLastNameTxt;
        private System.Windows.Forms.TextBox masterPhoneNumber;
        private System.Windows.Forms.Button masterOkBtn;
        private System.Windows.Forms.Button masterCancelBtn;
    }
}