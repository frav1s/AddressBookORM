namespace AddressBookUI
{
    partial class AddressBookViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showOld = new System.Windows.Forms.Button();
            this.showNew = new System.Windows.Forms.Button();
            this.infoNote = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addNewNote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editContactBtn = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ZAButton = new System.Windows.Forms.Button();
            this.AZButton = new System.Windows.Forms.Button();
            this.CreateContactLinkLabel = new System.Windows.Forms.Button();
            this.ContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailDisplayLabel = new System.Windows.Forms.Label();
            this.OfficePhoneDisplayLabel = new System.Windows.Forms.Label();
            this.Organization = new System.Windows.Forms.Label();
            this.CellPhoneDisplayLabel = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.StreetAddressOneLabel = new System.Windows.Forms.Label();
            this.HomePhoneDisplayLabel = new System.Windows.Forms.Label();
            this.StreetAddressTwoLabel = new System.Windows.Forms.Label();
            this.BirthdateDisplayLabel = new System.Windows.Forms.Label();
            this.NameDisplayLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.HomePhoneLabel = new System.Windows.Forms.Label();
            this.OfficePhoneLabel = new System.Windows.Forms.Label();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.ViewerFormTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.ContactInfoGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.showOld);
            this.tabPage2.Controls.Add(this.showNew);
            this.tabPage2.Controls.Add(this.infoNote);
            this.tabPage2.Controls.Add(this.delete);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.save);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.addNewNote);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.2F, System.Drawing.FontStyle.Bold);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1272, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заметки";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = global::AddressBookUI.Properties.Resources.delete_32px;
            this.button4.Location = new System.Drawing.Point(440, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.ExitSearch);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Результаты поиска";
            this.label1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 32);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.FindNoteAtThisDate);
            // 
            // showOld
            // 
            this.showOld.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.showOld.FlatAppearance.BorderSize = 0;
            this.showOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOld.ForeColor = System.Drawing.Color.White;
            this.showOld.Image = global::AddressBookUI.Properties.Resources.sort_down_64px;
            this.showOld.Location = new System.Drawing.Point(13, 67);
            this.showOld.Name = "showOld";
            this.showOld.Size = new System.Drawing.Size(64, 52);
            this.showOld.TabIndex = 9;
            this.showOld.UseVisualStyleBackColor = false;
            this.showOld.Click += new System.EventHandler(this.ShowOldNotes);
            // 
            // showNew
            // 
            this.showNew.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.showNew.FlatAppearance.BorderSize = 0;
            this.showNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showNew.ForeColor = System.Drawing.Color.White;
            this.showNew.Image = global::AddressBookUI.Properties.Resources.sort_up_64px;
            this.showNew.Location = new System.Drawing.Point(95, 71);
            this.showNew.Name = "showNew";
            this.showNew.Size = new System.Drawing.Size(64, 52);
            this.showNew.TabIndex = 8;
            this.showNew.UseVisualStyleBackColor = false;
            this.showNew.Click += new System.EventHandler(this.ShowNewNotes);
            // 
            // infoNote
            // 
            this.infoNote.AutoSize = true;
            this.infoNote.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18.2F, System.Drawing.FontStyle.Bold);
            this.infoNote.ForeColor = System.Drawing.Color.Black;
            this.infoNote.Location = new System.Drawing.Point(568, 61);
            this.infoNote.Name = "infoNote";
            this.infoNote.Size = new System.Drawing.Size(166, 30);
            this.infoNote.TabIndex = 6;
            this.infoNote.Text = "Заметка от ...";
            this.infoNote.Visible = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Image = global::AddressBookUI.Properties.Resources.trash_64px;
            this.delete.Location = new System.Drawing.Point(1162, 61);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(64, 64);
            this.delete.TabIndex = 5;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(13, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 486);
            this.panel1.TabIndex = 3;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Image = global::AddressBookUI.Properties.Resources.save_64px;
            this.save.Location = new System.Drawing.Point(1092, 61);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(64, 64);
            this.save.TabIndex = 2;
            this.save.UseVisualStyleBackColor = false;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.SaveEdit);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(572, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(654, 483);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // addNewNote
            // 
            this.addNewNote.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewNote.ForeColor = System.Drawing.Color.White;
            this.addNewNote.Location = new System.Drawing.Point(13, 14);
            this.addNewNote.Name = "addNewNote";
            this.addNewNote.Size = new System.Drawing.Size(457, 53);
            this.addNewNote.TabIndex = 0;
            this.addNewNote.Text = "Добавить новую заметку";
            this.addNewNote.UseVisualStyleBackColor = false;
            this.addNewNote.Click += new System.EventHandler(this.AddNewNote);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 691);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBoxSearchBy);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.editContactBtn);
            this.tabPage1.Controls.Add(this.RemoveButton);
            this.tabPage1.Controls.Add(this.ZAButton);
            this.tabPage1.Controls.Add(this.AZButton);
            this.tabPage1.Controls.Add(this.CreateContactLinkLabel);
            this.tabPage1.Controls.Add(this.ContactInfoGroupBox);
            this.tabPage1.Controls.Add(this.ContactListBox);
            this.tabPage1.Controls.Add(this.ViewerFormTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1272, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Адресная книга";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AddressBookUI.Properties.Resources.search_32px;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(376, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxSearchBy.ForeColor = System.Drawing.Color.White;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Организация",
            "Номер",
            "Email"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(230, 118);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(140, 30);
            this.comboBoxSearchBy.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(16, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 30);
            this.textBox1.TabIndex = 6;
            // 
            // editContactBtn
            // 
            this.editContactBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editContactBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editContactBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.editContactBtn.Image = global::AddressBookUI.Properties.Resources.edit_32px;
            this.editContactBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editContactBtn.Location = new System.Drawing.Point(1221, 74);
            this.editContactBtn.Name = "editContactBtn";
            this.editContactBtn.Size = new System.Drawing.Size(32, 32);
            this.editContactBtn.TabIndex = 5;
            this.editContactBtn.UseVisualStyleBackColor = false;
            this.editContactBtn.Click += new System.EventHandler(this.EditContactBtn_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Image = global::AddressBookUI.Properties.Resources.delete_32px;
            this.RemoveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveButton.Location = new System.Drawing.Point(1145, 74);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(32, 32);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ZAButton
            // 
            this.ZAButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ZAButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ZAButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ZAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZAButton.Image = global::AddressBookUI.Properties.Resources.alphabetical_sorting_2_32px;
            this.ZAButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ZAButton.Location = new System.Drawing.Point(54, 80);
            this.ZAButton.Name = "ZAButton";
            this.ZAButton.Size = new System.Drawing.Size(32, 32);
            this.ZAButton.TabIndex = 2;
            this.ZAButton.UseVisualStyleBackColor = true;
            this.ZAButton.Click += new System.EventHandler(this.ZAButton_Click);
            // 
            // AZButton
            // 
            this.AZButton.BackColor = System.Drawing.Color.Transparent;
            this.AZButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AZButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AZButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AZButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AZButton.Image = global::AddressBookUI.Properties.Resources.alphabetical_sorting_32px;
            this.AZButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AZButton.Location = new System.Drawing.Point(16, 80);
            this.AZButton.Name = "AZButton";
            this.AZButton.Size = new System.Drawing.Size(32, 32);
            this.AZButton.TabIndex = 1;
            this.AZButton.UseVisualStyleBackColor = false;
            this.AZButton.Click += new System.EventHandler(this.AZButton_Click);
            // 
            // CreateContactLinkLabel
            // 
            this.CreateContactLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateContactLinkLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CreateContactLinkLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateContactLinkLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CreateContactLinkLabel.FlatAppearance.BorderSize = 0;
            this.CreateContactLinkLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateContactLinkLabel.Image = global::AddressBookUI.Properties.Resources.plus_math_32px;
            this.CreateContactLinkLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateContactLinkLabel.Location = new System.Drawing.Point(1183, 74);
            this.CreateContactLinkLabel.Name = "CreateContactLinkLabel";
            this.CreateContactLinkLabel.Size = new System.Drawing.Size(32, 32);
            this.CreateContactLinkLabel.TabIndex = 4;
            this.CreateContactLinkLabel.UseVisualStyleBackColor = false;
            this.CreateContactLinkLabel.Click += new System.EventHandler(this.CreateContactLinkLabel_Click);
            // 
            // ContactInfoGroupBox
            // 
            this.ContactInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactInfoGroupBox.Controls.Add(this.EmailDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.OfficePhoneDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.Organization);
            this.ContactInfoGroupBox.Controls.Add(this.CellPhoneDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.Position);
            this.ContactInfoGroupBox.Controls.Add(this.StreetAddressOneLabel);
            this.ContactInfoGroupBox.Controls.Add(this.HomePhoneDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.StreetAddressTwoLabel);
            this.ContactInfoGroupBox.Controls.Add(this.BirthdateDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.NameDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.NameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.EmailLabel);
            this.ContactInfoGroupBox.Controls.Add(this.BirthdateLabel);
            this.ContactInfoGroupBox.Controls.Add(this.HomePhoneLabel);
            this.ContactInfoGroupBox.Controls.Add(this.OfficePhoneLabel);
            this.ContactInfoGroupBox.Controls.Add(this.CellPhoneLabel);
            this.ContactInfoGroupBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.2F, System.Drawing.FontStyle.Bold);
            this.ContactInfoGroupBox.ForeColor = System.Drawing.Color.White;
            this.ContactInfoGroupBox.Location = new System.Drawing.Point(443, 118);
            this.ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            this.ContactInfoGroupBox.Size = new System.Drawing.Size(810, 520);
            this.ContactInfoGroupBox.TabIndex = 4;
            this.ContactInfoGroupBox.TabStop = false;
            this.ContactInfoGroupBox.Text = "Иформация о контакте";
            // 
            // EmailDisplayLabel
            // 
            this.EmailDisplayLabel.AutoSize = true;
            this.EmailDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.EmailDisplayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmailDisplayLabel.Location = new System.Drawing.Point(371, 226);
            this.EmailDisplayLabel.Name = "EmailDisplayLabel";
            this.EmailDisplayLabel.Size = new System.Drawing.Size(124, 27);
            this.EmailDisplayLabel.TabIndex = 5;
            this.EmailDisplayLabel.Text = "<Тут Email>";
            this.EmailDisplayLabel.Visible = false;
            // 
            // OfficePhoneDisplayLabel
            // 
            this.OfficePhoneDisplayLabel.AutoSize = true;
            this.OfficePhoneDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OfficePhoneDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.OfficePhoneDisplayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OfficePhoneDisplayLabel.Location = new System.Drawing.Point(371, 271);
            this.OfficePhoneDisplayLabel.Name = "OfficePhoneDisplayLabel";
            this.OfficePhoneDisplayLabel.Size = new System.Drawing.Size(246, 27);
            this.OfficePhoneDisplayLabel.TabIndex = 5;
            this.OfficePhoneDisplayLabel.Text = "<Тут рабочий телефон>";
            this.OfficePhoneDisplayLabel.Visible = false;
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Organization.ForeColor = System.Drawing.Color.White;
            this.Organization.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Organization.Location = new System.Drawing.Point(371, 136);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(199, 27);
            this.Organization.TabIndex = 5;
            this.Organization.Text = "<Тут организация>";
            this.Organization.Visible = false;
            // 
            // CellPhoneDisplayLabel
            // 
            this.CellPhoneDisplayLabel.AutoSize = true;
            this.CellPhoneDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellPhoneDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.CellPhoneDisplayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CellPhoneDisplayLabel.Location = new System.Drawing.Point(371, 316);
            this.CellPhoneDisplayLabel.Name = "CellPhoneDisplayLabel";
            this.CellPhoneDisplayLabel.Size = new System.Drawing.Size(276, 27);
            this.CellPhoneDisplayLabel.TabIndex = 5;
            this.CellPhoneDisplayLabel.Text = "<Тут мобильный телефон>";
            this.CellPhoneDisplayLabel.Visible = false;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Position.ForeColor = System.Drawing.Color.White;
            this.Position.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Position.Location = new System.Drawing.Point(371, 181);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(179, 27);
            this.Position.TabIndex = 5;
            this.Position.Text = "<Тут должность>";
            this.Position.Visible = false;
            // 
            // StreetAddressOneLabel
            // 
            this.StreetAddressOneLabel.AutoSize = true;
            this.StreetAddressOneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetAddressOneLabel.ForeColor = System.Drawing.Color.White;
            this.StreetAddressOneLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StreetAddressOneLabel.Location = new System.Drawing.Point(17, 136);
            this.StreetAddressOneLabel.Name = "StreetAddressOneLabel";
            this.StreetAddressOneLabel.Size = new System.Drawing.Size(145, 27);
            this.StreetAddressOneLabel.TabIndex = 2;
            this.StreetAddressOneLabel.Text = "Организация";
            // 
            // HomePhoneDisplayLabel
            // 
            this.HomePhoneDisplayLabel.AutoSize = true;
            this.HomePhoneDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomePhoneDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.HomePhoneDisplayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HomePhoneDisplayLabel.Location = new System.Drawing.Point(371, 363);
            this.HomePhoneDisplayLabel.Name = "HomePhoneDisplayLabel";
            this.HomePhoneDisplayLabel.Size = new System.Drawing.Size(268, 27);
            this.HomePhoneDisplayLabel.TabIndex = 5;
            this.HomePhoneDisplayLabel.Text = "<Тут домашний телефон>";
            this.HomePhoneDisplayLabel.Visible = false;
            // 
            // StreetAddressTwoLabel
            // 
            this.StreetAddressTwoLabel.AutoSize = true;
            this.StreetAddressTwoLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetAddressTwoLabel.ForeColor = System.Drawing.Color.White;
            this.StreetAddressTwoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StreetAddressTwoLabel.Location = new System.Drawing.Point(17, 181);
            this.StreetAddressTwoLabel.Name = "StreetAddressTwoLabel";
            this.StreetAddressTwoLabel.Size = new System.Drawing.Size(125, 27);
            this.StreetAddressTwoLabel.TabIndex = 2;
            this.StreetAddressTwoLabel.Text = "Должность";
            // 
            // BirthdateDisplayLabel
            // 
            this.BirthdateDisplayLabel.AutoSize = true;
            this.BirthdateDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdateDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.BirthdateDisplayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BirthdateDisplayLabel.Location = new System.Drawing.Point(371, 91);
            this.BirthdateDisplayLabel.Name = "BirthdateDisplayLabel";
            this.BirthdateDisplayLabel.Size = new System.Drawing.Size(226, 27);
            this.BirthdateDisplayLabel.TabIndex = 5;
            this.BirthdateDisplayLabel.Text = "<Тут дата рождения>";
            this.BirthdateDisplayLabel.Visible = false;
            // 
            // NameDisplayLabel
            // 
            this.NameDisplayLabel.AutoSize = true;
            this.NameDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.NameDisplayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameDisplayLabel.Location = new System.Drawing.Point(371, 46);
            this.NameDisplayLabel.Name = "NameDisplayLabel";
            this.NameDisplayLabel.Size = new System.Drawing.Size(107, 27);
            this.NameDisplayLabel.TabIndex = 5;
            this.NameDisplayLabel.Text = "<Тут имя>";
            this.NameDisplayLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameLabel.Location = new System.Drawing.Point(17, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 27);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmailLabel.Location = new System.Drawing.Point(17, 226);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(73, 27);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdateLabel.ForeColor = System.Drawing.Color.White;
            this.BirthdateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BirthdateLabel.Location = new System.Drawing.Point(17, 91);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(177, 27);
            this.BirthdateLabel.TabIndex = 2;
            this.BirthdateLabel.Text = "Дата рождения:";
            // 
            // HomePhoneLabel
            // 
            this.HomePhoneLabel.AutoSize = true;
            this.HomePhoneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomePhoneLabel.ForeColor = System.Drawing.Color.White;
            this.HomePhoneLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HomePhoneLabel.Location = new System.Drawing.Point(17, 361);
            this.HomePhoneLabel.Name = "HomePhoneLabel";
            this.HomePhoneLabel.Size = new System.Drawing.Size(225, 27);
            this.HomePhoneLabel.TabIndex = 2;
            this.HomePhoneLabel.Text = "Телефон(домашний):";
            // 
            // OfficePhoneLabel
            // 
            this.OfficePhoneLabel.AutoSize = true;
            this.OfficePhoneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OfficePhoneLabel.ForeColor = System.Drawing.Color.White;
            this.OfficePhoneLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OfficePhoneLabel.Location = new System.Drawing.Point(17, 271);
            this.OfficePhoneLabel.Name = "OfficePhoneLabel";
            this.OfficePhoneLabel.Size = new System.Drawing.Size(203, 27);
            this.OfficePhoneLabel.TabIndex = 2;
            this.OfficePhoneLabel.Text = "Телефон(рабочий):";
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.CellPhoneLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CellPhoneLabel.Location = new System.Drawing.Point(17, 316);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(233, 27);
            this.CellPhoneLabel.TabIndex = 2;
            this.CellPhoneLabel.Text = "Телефон(мобильный):";
            // 
            // ContactListBox
            // 
            this.ContactListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ContactListBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18.75F);
            this.ContactListBox.ForeColor = System.Drawing.Color.White;
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.ItemHeight = 30;
            this.ContactListBox.Location = new System.Drawing.Point(16, 154);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(410, 394);
            this.ContactListBox.TabIndex = 1;
            this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
            // 
            // ViewerFormTitle
            // 
            this.ViewerFormTitle.AutoSize = true;
            this.ViewerFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ViewerFormTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ViewerFormTitle.Location = new System.Drawing.Point(555, 11);
            this.ViewerFormTitle.Name = "ViewerFormTitle";
            this.ViewerFormTitle.Size = new System.Drawing.Size(162, 106);
            this.ViewerFormTitle.TabIndex = 0;
            this.ViewerFormTitle.Text = "&&";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 700);
            this.tabControl1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImage = global::AddressBookUI.Properties.Resources.multiply_32px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(1249, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Exit_click);
            // 
            // AddressBookViewerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddressBookViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ContactInfoGroupBox.ResumeLayout(false);
            this.ContactInfoGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button editContactBtn;
        private System.Windows.Forms.Button CreateContactLinkLabel;
        private System.Windows.Forms.Button ZAButton;
        private System.Windows.Forms.Button AZButton;
        private System.Windows.Forms.GroupBox ContactInfoGroupBox;
        private System.Windows.Forms.Label EmailDisplayLabel;
        private System.Windows.Forms.Label OfficePhoneDisplayLabel;
        private System.Windows.Forms.Label Organization;
        private System.Windows.Forms.Label CellPhoneDisplayLabel;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label StreetAddressOneLabel;
        private System.Windows.Forms.Label HomePhoneDisplayLabel;
        private System.Windows.Forms.Label StreetAddressTwoLabel;
        private System.Windows.Forms.Label BirthdateDisplayLabel;
        private System.Windows.Forms.Label NameDisplayLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label HomePhoneLabel;
        private System.Windows.Forms.Label OfficePhoneLabel;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.Label ViewerFormTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addNewNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label infoNote;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showOld;
        private System.Windows.Forms.Button showNew;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RemoveButton;
    }
}
