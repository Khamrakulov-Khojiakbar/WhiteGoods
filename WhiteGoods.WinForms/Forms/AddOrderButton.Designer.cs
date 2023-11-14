namespace WhiteGoods.WinForms.Forms
{
    partial class AddOrderButton
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButtonAddOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddOrderButtonMenu = new System.Windows.Forms.Panel();
            this.technicChooseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.masterGetDataGridView = new System.Windows.Forms.DataGridView();
            this.clientAddressTextBox = new System.Windows.Forms.TextBox();
            this.deviceStatusCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deviceCauseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deviceSn = new System.Windows.Forms.TextBox();
            this.deviceModel = new System.Windows.Forms.TextBox();
            this.brandCombobox = new System.Windows.Forms.ComboBox();
            this.whichDeviceSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientPhoneNumberText = new System.Windows.Forms.TextBox();
            this.clientLastNameText = new System.Windows.Forms.TextBox();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.clientFirstname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAddOrderButtonMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.LimeGreen;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(714, 12);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(156, 38);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addButtonAddOrder
            // 
            this.addButtonAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButtonAddOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.addButtonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButtonAddOrder.Location = new System.Drawing.Point(551, 12);
            this.addButtonAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButtonAddOrder.Name = "addButtonAddOrder";
            this.addButtonAddOrder.Size = new System.Drawing.Size(156, 38);
            this.addButtonAddOrder.TabIndex = 12;
            this.addButtonAddOrder.Text = "Добавить";
            this.addButtonAddOrder.UseVisualStyleBackColor = false;
            this.addButtonAddOrder.Click += new System.EventHandler(this.addButtonAddOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.addButtonAddOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 63);
            this.panel1.TabIndex = 2;
            // 
            // panelAddOrderButtonMenu
            // 
            this.panelAddOrderButtonMenu.AutoScroll = true;
            this.panelAddOrderButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelAddOrderButtonMenu.Controls.Add(this.technicChooseButton);
            this.panelAddOrderButtonMenu.Controls.Add(this.label6);
            this.panelAddOrderButtonMenu.Controls.Add(this.masterGetDataGridView);
            this.panelAddOrderButtonMenu.Controls.Add(this.clientAddressTextBox);
            this.panelAddOrderButtonMenu.Controls.Add(this.deviceStatusCombobox);
            this.panelAddOrderButtonMenu.Controls.Add(this.label5);
            this.panelAddOrderButtonMenu.Controls.Add(this.deviceCauseTextBox);
            this.panelAddOrderButtonMenu.Controls.Add(this.label4);
            this.panelAddOrderButtonMenu.Controls.Add(this.label3);
            this.panelAddOrderButtonMenu.Controls.Add(this.deviceSn);
            this.panelAddOrderButtonMenu.Controls.Add(this.deviceModel);
            this.panelAddOrderButtonMenu.Controls.Add(this.brandCombobox);
            this.panelAddOrderButtonMenu.Controls.Add(this.whichDeviceSelectCombobox);
            this.panelAddOrderButtonMenu.Controls.Add(this.label2);
            this.panelAddOrderButtonMenu.Controls.Add(this.label1);
            this.panelAddOrderButtonMenu.Controls.Add(this.clientPhoneNumberText);
            this.panelAddOrderButtonMenu.Controls.Add(this.clientLastNameText);
            this.panelAddOrderButtonMenu.Controls.Add(this.clientNameBox);
            this.panelAddOrderButtonMenu.Controls.Add(this.clientFirstname);
            this.panelAddOrderButtonMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddOrderButtonMenu.Location = new System.Drawing.Point(0, 63);
            this.panelAddOrderButtonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAddOrderButtonMenu.MinimumSize = new System.Drawing.Size(882, 658);
            this.panelAddOrderButtonMenu.Name = "panelAddOrderButtonMenu";
            this.panelAddOrderButtonMenu.Size = new System.Drawing.Size(882, 658);
            this.panelAddOrderButtonMenu.TabIndex = 3;
            // 
            // technicChooseButton
            // 
            this.technicChooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.technicChooseButton.Location = new System.Drawing.Point(649, 533);
            this.technicChooseButton.Name = "technicChooseButton";
            this.technicChooseButton.Size = new System.Drawing.Size(156, 36);
            this.technicChooseButton.TabIndex = 11;
            this.technicChooseButton.Text = "Выбрать";
            this.technicChooseButton.UseVisualStyleBackColor = true;
            this.technicChooseButton.Click += new System.EventHandler(this.technicChooseButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(455, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Мастер:";
            // 
            // masterGetDataGridView
            // 
            this.masterGetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.masterGetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterGetDataGridView.Location = new System.Drawing.Point(460, 275);
            this.masterGetDataGridView.Name = "masterGetDataGridView";
            this.masterGetDataGridView.RowHeadersWidth = 51;
            this.masterGetDataGridView.RowTemplate.Height = 24;
            this.masterGetDataGridView.Size = new System.Drawing.Size(345, 252);
            this.masterGetDataGridView.TabIndex = 25;
            this.masterGetDataGridView.Enter += new System.EventHandler(this.masterGetDataGridView_Enter);
            // 
            // clientAddressTextBox
            // 
            this.clientAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientAddressTextBox.Location = new System.Drawing.Point(450, 34);
            this.clientAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientAddressTextBox.Name = "clientAddressTextBox";
            this.clientAddressTextBox.Size = new System.Drawing.Size(199, 28);
            this.clientAddressTextBox.TabIndex = 3;
            this.clientAddressTextBox.Enter += new System.EventHandler(this.clientAddressTextBox_Enter);
            this.clientAddressTextBox.Leave += new System.EventHandler(this.clientAddressTextBox_Leave);
            // 
            // deviceStatusCombobox
            // 
            this.deviceStatusCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceStatusCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceStatusCombobox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deviceStatusCombobox.FormattingEnabled = true;
            this.deviceStatusCombobox.Location = new System.Drawing.Point(460, 198);
            this.deviceStatusCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deviceStatusCombobox.Name = "deviceStatusCombobox";
            this.deviceStatusCombobox.Size = new System.Drawing.Size(201, 30);
            this.deviceStatusCombobox.TabIndex = 10;
            this.deviceStatusCombobox.Click += new System.EventHandler(this.deviceStatusCombobox_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(455, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Статус ремонта:";
            // 
            // deviceCauseTextBox
            // 
            this.deviceCauseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceCauseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceCauseTextBox.Location = new System.Drawing.Point(8, 455);
            this.deviceCauseTextBox.Name = "deviceCauseTextBox";
            this.deviceCauseTextBox.Size = new System.Drawing.Size(345, 28);
            this.deviceCauseTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Неисправность со слов клиента :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-523, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(928, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // deviceSn
            // 
            this.deviceSn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceSn.Location = new System.Drawing.Point(14, 317);
            this.deviceSn.Name = "deviceSn";
            this.deviceSn.Size = new System.Drawing.Size(210, 28);
            this.deviceSn.TabIndex = 8;
            this.deviceSn.Enter += new System.EventHandler(this.deviceSn_Enter);
            this.deviceSn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deviceSn_KeyPress);
            this.deviceSn.Leave += new System.EventHandler(this.deviceSn_Leave);
            // 
            // deviceModel
            // 
            this.deviceModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceModel.Location = new System.Drawing.Point(14, 265);
            this.deviceModel.Name = "deviceModel";
            this.deviceModel.Size = new System.Drawing.Size(210, 28);
            this.deviceModel.TabIndex = 7;
            this.deviceModel.Enter += new System.EventHandler(this.deviceModel_Enter);
            this.deviceModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deviceModel_KeyPress);
            this.deviceModel.Leave += new System.EventHandler(this.deviceModel_Leave);
            // 
            // brandCombobox
            // 
            this.brandCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brandCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandCombobox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brandCombobox.FormattingEnabled = true;
            this.brandCombobox.Location = new System.Drawing.Point(203, 198);
            this.brandCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandCombobox.Name = "brandCombobox";
            this.brandCombobox.Size = new System.Drawing.Size(150, 30);
            this.brandCombobox.TabIndex = 6;
            this.brandCombobox.Click += new System.EventHandler(this.brandCombobox_Click);
            this.brandCombobox.Enter += new System.EventHandler(this.brandCombobox_Enter);
            this.brandCombobox.Leave += new System.EventHandler(this.brandCombobox_Leave);
            // 
            // whichDeviceSelectCombobox
            // 
            this.whichDeviceSelectCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.whichDeviceSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whichDeviceSelectCombobox.FormattingEnabled = true;
            this.whichDeviceSelectCombobox.Location = new System.Drawing.Point(14, 198);
            this.whichDeviceSelectCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.whichDeviceSelectCombobox.Name = "whichDeviceSelectCombobox";
            this.whichDeviceSelectCombobox.Size = new System.Drawing.Size(175, 30);
            this.whichDeviceSelectCombobox.TabIndex = 5;
            this.whichDeviceSelectCombobox.Click += new System.EventHandler(this.whichDeviceSelectCombobox_Click);
            this.whichDeviceSelectCombobox.Enter += new System.EventHandler(this.whichDeviceSelectCombobox_Enter);
            this.whichDeviceSelectCombobox.Leave += new System.EventHandler(this.whichDeviceSelectCombobox_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Устройство:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-34, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // clientPhoneNumberText
            // 
            this.clientPhoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientPhoneNumberText.Location = new System.Drawing.Point(26, 77);
            this.clientPhoneNumberText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientPhoneNumberText.Name = "clientPhoneNumberText";
            this.clientPhoneNumberText.Size = new System.Drawing.Size(198, 28);
            this.clientPhoneNumberText.TabIndex = 4;
            this.clientPhoneNumberText.Enter += new System.EventHandler(this.clientPhoneNumberText_Enter);
            this.clientPhoneNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientPhoneNumberText_KeyPress);
            this.clientPhoneNumberText.Leave += new System.EventHandler(this.clientPhoneNumberText_Leave);
            // 
            // clientLastNameText
            // 
            this.clientLastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLastNameText.Location = new System.Drawing.Point(230, 34);
            this.clientLastNameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientLastNameText.Name = "clientLastNameText";
            this.clientLastNameText.Size = new System.Drawing.Size(214, 28);
            this.clientLastNameText.TabIndex = 2;
            this.clientLastNameText.Enter += new System.EventHandler(this.clientLastNameText_Enter);
            this.clientLastNameText.Leave += new System.EventHandler(this.clientLastNameText_Leave);
            // 
            // clientNameBox
            // 
            this.clientNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientNameBox.Location = new System.Drawing.Point(26, 34);
            this.clientNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientNameBox.Name = "clientNameBox";
            this.clientNameBox.Size = new System.Drawing.Size(198, 28);
            this.clientNameBox.TabIndex = 1;
            this.clientNameBox.Enter += new System.EventHandler(this.clientBox_Enter);
            this.clientNameBox.Leave += new System.EventHandler(this.clientBox_Leave);
            // 
            // clientFirstname
            // 
            this.clientFirstname.AutoSize = true;
            this.clientFirstname.Font = new System.Drawing.Font("Arial Black", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientFirstname.Location = new System.Drawing.Point(3, 2);
            this.clientFirstname.Name = "clientFirstname";
            this.clientFirstname.Size = new System.Drawing.Size(302, 30);
            this.clientFirstname.TabIndex = 0;
            this.clientFirstname.Text = "Информация о клиенте:";
            // 
            // AddOrderButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(882, 721);
            this.Controls.Add(this.panelAddOrderButtonMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(900, 768);
            this.Name = "AddOrderButton";
            this.Text = "Создание ремонта";
            this.Load += new System.EventHandler(this.AddOrderButton_Load);
            this.panel1.ResumeLayout(false);
            this.panelAddOrderButtonMenu.ResumeLayout(false);
            this.panelAddOrderButtonMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButtonAddOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAddOrderButtonMenu;
        private System.Windows.Forms.TextBox clientNameBox;
        private System.Windows.Forms.Label clientFirstname;
        private System.Windows.Forms.TextBox clientPhoneNumberText;
        private System.Windows.Forms.TextBox clientLastNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox whichDeviceSelectCombobox;
        private System.Windows.Forms.ComboBox brandCombobox;
        private System.Windows.Forms.TextBox deviceModel;
        private System.Windows.Forms.TextBox deviceSn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deviceCauseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deviceStatusCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientAddressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView masterGetDataGridView;
        private System.Windows.Forms.Button technicChooseButton;
    }
}