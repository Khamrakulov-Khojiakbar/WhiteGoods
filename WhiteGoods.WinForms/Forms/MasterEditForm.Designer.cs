namespace WhiteGoods.WinForms.Forms
{
    partial class MasterEditForm
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
            this.masterNameTxt = new System.Windows.Forms.TextBox();
            this.masterNameLabel = new System.Windows.Forms.Label();
            this.masterLastNameLabel = new System.Windows.Forms.Label();
            this.masterLastNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masterPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.is_selected = new System.Windows.Forms.CheckBox();
            this.is_deletedChechBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masterNameTxt
            // 
            this.masterNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterNameTxt.Location = new System.Drawing.Point(36, 66);
            this.masterNameTxt.Name = "masterNameTxt";
            this.masterNameTxt.Size = new System.Drawing.Size(192, 26);
            this.masterNameTxt.TabIndex = 0;
            // 
            // masterNameLabel
            // 
            this.masterNameLabel.AutoSize = true;
            this.masterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterNameLabel.Location = new System.Drawing.Point(33, 37);
            this.masterNameLabel.Name = "masterNameLabel";
            this.masterNameLabel.Size = new System.Drawing.Size(45, 20);
            this.masterNameLabel.TabIndex = 1;
            this.masterNameLabel.Text = "Имя";
            // 
            // masterLastNameLabel
            // 
            this.masterLastNameLabel.AutoSize = true;
            this.masterLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterLastNameLabel.Location = new System.Drawing.Point(33, 122);
            this.masterLastNameLabel.Name = "masterLastNameLabel";
            this.masterLastNameLabel.Size = new System.Drawing.Size(94, 20);
            this.masterLastNameLabel.TabIndex = 3;
            this.masterLastNameLabel.Text = "Фамилия";
            // 
            // masterLastNameTxt
            // 
            this.masterLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterLastNameTxt.Location = new System.Drawing.Point(36, 151);
            this.masterLastNameTxt.Name = "masterLastNameTxt";
            this.masterLastNameTxt.Size = new System.Drawing.Size(192, 26);
            this.masterLastNameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тел номер";
            // 
            // masterPhoneNumberTxt
            // 
            this.masterPhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterPhoneNumberTxt.Location = new System.Drawing.Point(36, 234);
            this.masterPhoneNumberTxt.Name = "masterPhoneNumberTxt";
            this.masterPhoneNumberTxt.Size = new System.Drawing.Size(192, 26);
            this.masterPhoneNumberTxt.TabIndex = 4;
            // 
            // is_selected
            // 
            this.is_selected.AutoSize = true;
            this.is_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_selected.Location = new System.Drawing.Point(437, 66);
            this.is_selected.Name = "is_selected";
            this.is_selected.Size = new System.Drawing.Size(95, 24);
            this.is_selected.TabIndex = 6;
            this.is_selected.Text = "Выбран";
            this.is_selected.UseVisualStyleBackColor = true;
            // 
            // is_deletedChechBox
            // 
            this.is_deletedChechBox.AutoSize = true;
            this.is_deletedChechBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_deletedChechBox.Location = new System.Drawing.Point(437, 149);
            this.is_deletedChechBox.Name = "is_deletedChechBox";
            this.is_deletedChechBox.Size = new System.Drawing.Size(94, 24);
            this.is_deletedChechBox.TabIndex = 7;
            this.is_deletedChechBox.Text = "Удален";
            this.is_deletedChechBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(437, 391);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(190, 30);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(599, 391);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(190, 30);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MasterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.is_deletedChechBox);
            this.Controls.Add(this.is_selected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.masterPhoneNumberTxt);
            this.Controls.Add(this.masterLastNameLabel);
            this.Controls.Add(this.masterLastNameTxt);
            this.Controls.Add(this.masterNameLabel);
            this.Controls.Add(this.masterNameTxt);
            this.Name = "MasterEditForm";
            this.Text = "MasterEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox masterNameTxt;
        private System.Windows.Forms.Label masterNameLabel;
        private System.Windows.Forms.Label masterLastNameLabel;
        private System.Windows.Forms.TextBox masterLastNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox masterPhoneNumberTxt;
        private System.Windows.Forms.CheckBox is_selected;
        private System.Windows.Forms.CheckBox is_deletedChechBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}