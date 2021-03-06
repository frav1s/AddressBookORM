namespace AddressBookService
{
    partial class CreateContactForm
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
            this.createContactTitle = new System.Windows.Forms.Label();
            this.createContactButton = new System.Windows.Forms.Button();

            this.birthDateLabel = new System.Windows.Forms.Label();
            this.homePhoneLabel = new System.Windows.Forms.Label();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.officePhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailAddressValue = new System.Windows.Forms.TextBox();
            this.OrganizationValue = new System.Windows.Forms.TextBox();
            this.PositionValue = new System.Windows.Forms.TextBox();

            this.cancelExitButton = new System.Windows.Forms.Button();
            this.contactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.birthDateExLabel = new System.Windows.Forms.Label();
            this.officePhoneValue = new System.Windows.Forms.MaskedTextBox();
            this.homePhoneValue = new System.Windows.Forms.MaskedTextBox();
            this.cellPhoneValue = new System.Windows.Forms.MaskedTextBox();
            this.birthDateValue = new System.Windows.Forms.MaskedTextBox();
            this.clearCreateContactForm = new System.Windows.Forms.LinkLabel();
            this.messageLbl = new System.Windows.Forms.Label();
            this.contactInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createContactTitle
            // 
            this.createContactTitle.AutoSize = true;
            this.createContactTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25.2F, System.Drawing.FontStyle.Bold);
            this.createContactTitle.ForeColor = System.Drawing.Color.White;
            this.createContactTitle.Location = new System.Drawing.Point(12, 9);
            this.createContactTitle.Name = "createContactTitle";
            this.createContactTitle.Size = new System.Drawing.Size(388, 41);
            this.createContactTitle.TabIndex = 0;
            this.createContactTitle.Text = "Создать новый контакт";
            // 
            // createContactButton
            // 
            this.createContactButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createContactButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.createContactButton.ForeColor = System.Drawing.Color.White;
            this.createContactButton.Location = new System.Drawing.Point(751, 77);
            this.createContactButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createContactButton.Name = "createContactButton";
            this.createContactButton.Size = new System.Drawing.Size(161, 51);
            this.createContactButton.TabIndex = 13;
            this.createContactButton.Text = "Добавить";
            this.createContactButton.UseVisualStyleBackColor = true;
            this.createContactButton.Click += new System.EventHandler(this.CreateContactButton_Click);
            // 
            // CreateContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.clearCreateContactForm);
            this.Controls.Add(this.contactInfoGroupBox);
            this.Controls.Add(this.cancelExitButton);
            this.Controls.Add(this.createContactButton);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.createContactTitle);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать контакт";
            this.contactInfoGroupBox.ResumeLayout(false);
            this.contactInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();






            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.birthDateLabel.Location = new System.Drawing.Point(36, 117);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(177, 27);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Дата рождения:";
            // 
            // homePhoneLabel
            // 
            this.homePhoneLabel.AutoSize = true;
            this.homePhoneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.homePhoneLabel.ForeColor = System.Drawing.Color.White;
            this.homePhoneLabel.Location = new System.Drawing.Point(582, 237);
            this.homePhoneLabel.Name = "homePhoneLabel";
            this.homePhoneLabel.Size = new System.Drawing.Size(225, 27);
            this.homePhoneLabel.TabIndex = 2;
            this.homePhoneLabel.Text = "Телефон(домашний):";
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.cellPhoneLabel.Location = new System.Drawing.Point(582, 177);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(228, 27);
            this.cellPhoneLabel.TabIndex = 2;
            this.cellPhoneLabel.Text = "Телефон(мобильный)";
            // 
            // officePhoneLabel
            // 
            this.officePhoneLabel.AutoSize = true;
            this.officePhoneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.officePhoneLabel.ForeColor = System.Drawing.Color.White;
            this.officePhoneLabel.Location = new System.Drawing.Point(582, 297);
            this.officePhoneLabel.Name = "officePhoneLabel";
            this.officePhoneLabel.Size = new System.Drawing.Size(203, 27);
            this.officePhoneLabel.TabIndex = 2;
            this.officePhoneLabel.Text = "Телефон(рабочий):";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(36, 297);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 27);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // streetAddressOneLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.OrganizationLabel.Location = new System.Drawing.Point(36, 177);
            this.OrganizationLabel.Name = "streetAddressOneLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(150, 27);
            this.OrganizationLabel.TabIndex = 2;
            this.OrganizationLabel.Text = "Организация:";
            // 
            // streetAddressTwoLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.PositionLabel.Location = new System.Drawing.Point(36, 237);
            this.PositionLabel.Name = "streetAddressTwoLabel";
            this.PositionLabel.Size = new System.Drawing.Size(130, 27);
            this.PositionLabel.TabIndex = 2;
            this.PositionLabel.Text = "Должность:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(87, 128);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(105, 27);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(87, 77);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 27);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Имя:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.firstNameValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.firstNameValue.ForeColor = System.Drawing.Color.White;
            this.firstNameValue.Location = new System.Drawing.Point(321, 77);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(247, 33);
            this.firstNameValue.TabIndex = 1;
            // 
            // lastNameValue
            // 
            this.lastNameValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.lastNameValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lastNameValue.ForeColor = System.Drawing.Color.White;
            this.lastNameValue.Location = new System.Drawing.Point(321, 122);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(247, 33);
            this.lastNameValue.TabIndex = 2;
            // 
            // emailAddressValue
            // 
            this.emailAddressValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.emailAddressValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.emailAddressValue.ForeColor = System.Drawing.Color.White;
            this.emailAddressValue.Location = new System.Drawing.Point(270, 293);
            this.emailAddressValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailAddressValue.Name = "emailAddressValue";
            this.emailAddressValue.Size = new System.Drawing.Size(249, 33);
            this.emailAddressValue.TabIndex = 7;
            // 
            // OrganizationValue
            // 
            this.OrganizationValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.OrganizationValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.OrganizationValue.ForeColor = System.Drawing.Color.White;
            this.OrganizationValue.Location = new System.Drawing.Point(270, 235);
            this.OrganizationValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrganizationValue.Name = "OrganizationValue";
            this.OrganizationValue.Size = new System.Drawing.Size(249, 33);
            this.OrganizationValue.TabIndex = 8;
            // 
            // PositionValue
            // 
            this.PositionValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.PositionValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.PositionValue.ForeColor = System.Drawing.Color.White;
            this.PositionValue.Location = new System.Drawing.Point(270, 177);
            this.PositionValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PositionValue.Name = "PositionValue";
            this.PositionValue.Size = new System.Drawing.Size(249, 33);
            this.PositionValue.TabIndex = 9;

            // 
            // cancelExitButton
            // 
            this.cancelExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cancelExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cancelExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelExitButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.cancelExitButton.ForeColor = System.Drawing.Color.White;
            this.cancelExitButton.Location = new System.Drawing.Point(970, 77);
            this.cancelExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelExitButton.Name = "cancelExitButton";
            this.cancelExitButton.Size = new System.Drawing.Size(180, 51);
            this.cancelExitButton.TabIndex = 14;
            this.cancelExitButton.Text = "Отменить";
            this.cancelExitButton.UseVisualStyleBackColor = true;
            this.cancelExitButton.Click += new System.EventHandler(this.CancelExitButton_Click);
            // 
            // contactInfoGroupBox
            // 
            this.contactInfoGroupBox.Controls.Add(this.birthDateExLabel);
            this.contactInfoGroupBox.Controls.Add(this.officePhoneValue);
            this.contactInfoGroupBox.Controls.Add(this.homePhoneValue);
            this.contactInfoGroupBox.Controls.Add(this.cellPhoneValue);
            this.contactInfoGroupBox.Controls.Add(this.birthDateValue);
            this.contactInfoGroupBox.Controls.Add(this.birthDateLabel);
            this.contactInfoGroupBox.Controls.Add(this.homePhoneLabel);
            this.contactInfoGroupBox.Controls.Add(this.cellPhoneLabel);
            this.contactInfoGroupBox.Controls.Add(this.officePhoneLabel);
            this.contactInfoGroupBox.Controls.Add(this.emailLabel);
            this.contactInfoGroupBox.Controls.Add(this.PositionValue);
            this.contactInfoGroupBox.Controls.Add(this.OrganizationValue);
            this.contactInfoGroupBox.Controls.Add(this.emailAddressValue);
            this.contactInfoGroupBox.Controls.Add(this.OrganizationLabel);
            this.contactInfoGroupBox.Controls.Add(this.PositionLabel);
            this.contactInfoGroupBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.2F, System.Drawing.FontStyle.Bold);
            this.contactInfoGroupBox.ForeColor = System.Drawing.Color.White;
            this.contactInfoGroupBox.Location = new System.Drawing.Point(51, 182);
            this.contactInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactInfoGroupBox.Name = "contactInfoGroupBox";
            this.contactInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactInfoGroupBox.Size = new System.Drawing.Size(1181, 467);
            this.contactInfoGroupBox.TabIndex = 6;
            this.contactInfoGroupBox.TabStop = false;
            this.contactInfoGroupBox.Text = "Информация о контакте";
            // 
            // birthDateExLabel
            // 
            this.birthDateExLabel.AutoSize = true;
            this.birthDateExLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthDateExLabel.ForeColor = System.Drawing.Color.White;
            this.birthDateExLabel.Location = new System.Drawing.Point(408, 130);
            this.birthDateExLabel.Name = "birthDateExLabel";
            this.birthDateExLabel.Size = new System.Drawing.Size(91, 15);
            this.birthDateExLabel.TabIndex = 13;
            this.birthDateExLabel.Text = "(MM/DD/YYYY)";
            // 
            // officePhoneValue
            // 
            this.officePhoneValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.officePhoneValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.officePhoneValue.ForeColor = System.Drawing.Color.White;
            this.officePhoneValue.Location = new System.Drawing.Point(883, 295);
            this.officePhoneValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.officePhoneValue.Mask = "(999) 000-0000";
            this.officePhoneValue.Name = "officePhoneValue";
            this.officePhoneValue.Size = new System.Drawing.Size(181, 33);
            this.officePhoneValue.TabIndex = 6;
            // 
            // homePhoneValue
            // 
            this.homePhoneValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.homePhoneValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.homePhoneValue.ForeColor = System.Drawing.Color.White;
            this.homePhoneValue.Location = new System.Drawing.Point(883, 235);
            this.homePhoneValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePhoneValue.Mask = "(999) 000-0000";
            this.homePhoneValue.Name = "homePhoneValue";
            this.homePhoneValue.Size = new System.Drawing.Size(181, 33);
            this.homePhoneValue.TabIndex = 5;
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.cellPhoneValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.cellPhoneValue.ForeColor = System.Drawing.Color.White;
            this.cellPhoneValue.Location = new System.Drawing.Point(883, 173);
            this.cellPhoneValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellPhoneValue.Mask = "(999) 000-0000";
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(181, 33);
            this.cellPhoneValue.TabIndex = 4;
            // 
            // birthDateValue
            // 
            this.birthDateValue.BackColor = System.Drawing.SystemColors.GrayText;
            this.birthDateValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.birthDateValue.ForeColor = System.Drawing.Color.White;
            this.birthDateValue.Location = new System.Drawing.Point(270, 115);
            this.birthDateValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDateValue.Mask = "00/00/0000";
            this.birthDateValue.Name = "birthDateValue";
            this.birthDateValue.Size = new System.Drawing.Size(139, 33);
            this.birthDateValue.TabIndex = 3;
            // 
            // clearCreateContactForm
            // 
            this.clearCreateContactForm.AutoSize = true;
            this.clearCreateContactForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.clearCreateContactForm.ForeColor = System.Drawing.Color.White;
            this.clearCreateContactForm.LinkColor = System.Drawing.Color.White;
            this.clearCreateContactForm.Location = new System.Drawing.Point(1128, 161);
            this.clearCreateContactForm.Name = "clearCreateContactForm";
            this.clearCreateContactForm.Size = new System.Drawing.Size(107, 27);
            this.clearCreateContactForm.TabIndex = 15;
            this.clearCreateContactForm.TabStop = true;
            this.clearCreateContactForm.Text = "Очистить";
            this.clearCreateContactForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearCreateContactForm_LinkClicked);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.messageLbl.ForeColor = System.Drawing.Color.Red;
            this.messageLbl.Location = new System.Drawing.Point(410, 21);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(160, 27);
            this.messageLbl.TabIndex = 16;
            this.messageLbl.Text = "<Message text>";
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.messageLbl.Visible = false;


        }

        #endregion

        private System.Windows.Forms.Label createContactTitle;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label homePhoneLabel;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.Label officePhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox emailAddressValue;
        private System.Windows.Forms.TextBox OrganizationValue;
        private System.Windows.Forms.TextBox PositionValue;
        private System.Windows.Forms.Button createContactButton;
        private System.Windows.Forms.Button cancelExitButton;
        private System.Windows.Forms.GroupBox contactInfoGroupBox;
        private System.Windows.Forms.MaskedTextBox officePhoneValue;
        private System.Windows.Forms.MaskedTextBox homePhoneValue;
        private System.Windows.Forms.MaskedTextBox cellPhoneValue;
        private System.Windows.Forms.MaskedTextBox birthDateValue;
        private System.Windows.Forms.LinkLabel clearCreateContactForm;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label birthDateExLabel;
    }
}