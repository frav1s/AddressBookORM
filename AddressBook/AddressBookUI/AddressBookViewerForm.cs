using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary;
using AddressBookLibrary.Repository;
using AddressBookService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AddressBookUI
{
    public partial class AddressBookViewerForm : Form, IContactRequestor
    {

       // private readonly EfGenericRepository<Person> PersonRepository =
        //    new EfGenericRepository<Person>(new AddressBookDbContext());

        /// <summary>
        ///     _knownContacts заполненный FillListBox() методом; _sortedContacts временный список
        /// </summary>
        private List<Person> _knownContacts = new List<Person>();
        LogicContact service = new LogicContact();
        private List<Person> _sortedContacts = new List<Person>();

        /// <summary>
        ///     Конструктор форм, загружает контакты в список
        /// </summary>
        public AddressBookViewerForm()
        {
            InitializeComponent();
            FillListBox();
            LoadNote();
            DrawNotes();
            
        }

        /// <summary>
        ///     Добавляет контакт в список контактов
        /// </summary>
        /// <param name="contact">
        ///     Объект контактной модели
        /// </param>
        public void ContactComplete(Person contact)
        {
            _knownContacts.Add(contact);
            FillListBox();
        }

        /// <summary>
        ///     Заполняет список контактов _knownContacts
        /// </summary>
        private void FillListBox()
        {

            _knownContacts = service.GetAllContact();
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = _knownContacts;
            ContactListBox.DisplayMember = "FullNameLast";
        }

        /// <summary>
        ///     Метод сортировки отображает записи по возрастанию, заполняет поле списка
        /// </summary>
        private void SortListBox()
        {
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = _sortedContacts;
            ContactListBox.DisplayMember = "FullNameLast";
            _sortedContacts.Clear();
        }
        /// <summary>
        ///     Запускает форму создания контакта, передает текущий экземпляр формы просмотра
        /// </summary>
        private void CreateContactLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            var frm = new CreateContactForm(this);
            frm.Show();
        }

        /// <summary>
        ///     При выборе элемента списка отображается контактная информация
        /// </summary>
        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayContactInfo();
            LoadContactInfo((Person)ContactListBox.SelectedItem);
        }

        /// <summary>
        ///     Отображает метки форм
        /// </summary>
        private void DisplayContactInfo()
        {
            var isVisible = _knownContacts.Count > 0;

            NameDisplayLabel.Visible = isVisible;
            BirthdateDisplayLabel.Visible = isVisible;
            CellPhoneDisplayLabel.Visible = isVisible;
            HomePhoneDisplayLabel.Visible = isVisible;
            OfficePhoneDisplayLabel.Visible = isVisible;
            EmailDisplayLabel.Visible = isVisible;
            Position.Visible = isVisible;
            Organization.Visible = isVisible;
        }

        /// <summary>
        ///     Отображает информацию, содержащуюся в объекте модели контакта
        /// </summary>
        /// <param name="model">
        ///     Объект контактной модели
        /// </param>
        private void LoadContactInfo(Person model)
        {
            if (model != null)
            {
                NameDisplayLabel.Text = model.FullNameFirst;
                BirthdateDisplayLabel.Text = model.BirthDate;
                CellPhoneDisplayLabel.Text = model.CellPhone;
                HomePhoneDisplayLabel.Text = model.HomePhone;
                OfficePhoneDisplayLabel.Text = model.OfficePhone;
                EmailDisplayLabel.Text = model.EmailAddress;
                Position.Text = model.Organization;
                Organization.Text = model.Position;

                if (BirthdateDisplayLabel.Text == "  /  /") BirthdateDisplayLabel.Visible = false;
                if (CellPhoneDisplayLabel.Text == "(   )    -") CellPhoneDisplayLabel.Visible = false;
                if (HomePhoneDisplayLabel.Text == "(   )    -") HomePhoneDisplayLabel.Visible = false;
                if (OfficePhoneDisplayLabel.Text == "(   )    -") OfficePhoneDisplayLabel.Visible = false;
            }
        }

        /// <summary>
        ///     Удаляет запись списка из базы данных
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var contact = (Person)ContactListBox.SelectedItem;
            if (contact != null)
            {
                service.DeleteContact(contact);
                _knownContacts = service.GetAllContact();
                FillListBox();
            }
            else
            {
                MessageBox.Show("Select a contact first!");
            }
        }

        /// <summary>
        ///     Вызывает AscSortListBox()
        /// </summary>
        private void AZButton_Click(object sender, EventArgs e)
        {
            _sortedContacts = _knownContacts.OrderBy(x => x.FullNameLast).ToList();
            SortListBox();
        }

        /// <summary>
        ///     Вызывает DescSortListBox()
        /// </summary>
        private void ZAButton_Click(object sender, EventArgs e)
        {
            _sortedContacts = _knownContacts.OrderByDescending(x => x.FullNameLast).ToList();
            SortListBox();
        }

        /// <summary>
        ///     Запускает форму редактирования контакта для выбранного контакта
        /// </summary>
        private void EditContactBtn_Click(object sender, EventArgs e)
        {
            var frm = new EditContactForm(this);
            var contact = (Person)ContactListBox.SelectedItem;
            if (contact != null)
            {
                //frm.Show();
                frm.ContactEdit = contact;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Select a contact first!");
            }
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var searchingString = textBox1.Text;
            _sortedContacts = null;
            if (searchingString == "")
            {
                ContactListBox.DataSource = _knownContacts;
                return;
            }

            var searchingIn = comboBoxSearchBy.SelectedIndex;
            switch (searchingIn)
            {
                case 0:
                    _sortedContacts = _knownContacts.FindAll(x => x.FirstName == searchingString);
                    break;

                case 1:
                    _sortedContacts = _knownContacts.FindAll(x => x.LastName == searchingString);
                    break;

                case 2:
                    _sortedContacts = _knownContacts.FindAll(x => x.Organization == searchingString);
                    break;

                case 3:
                    {
                        _sortedContacts = _knownContacts.FindAll(x =>
                            searchingString == x.HomePhone || searchingString == x.CellPhone ||
                            searchingString == x.OfficePhone);
                        break;
                    }
                case 4:
                    _sortedContacts = _knownContacts.FindAll(x => x.EmailAddress == searchingString);
                    break;
            }

            if (_sortedContacts == null)
                MessageBox.Show("Not Found");
            else
                ContactListBox.DataSource = _sortedContacts;
        }

        private void CreateContactLinkLabel_Click(object sender, EventArgs e)
        {
            var frm = new CreateContactForm(this);
            frm.Show();
        }
    }
}