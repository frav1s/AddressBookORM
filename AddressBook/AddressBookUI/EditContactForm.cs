using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using AddressBookLibrary.Validation;
using AddressBookLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AddressBookService;

namespace AddressBookUI
{
    public partial class EditContactForm : Form
    {
        private readonly IContactRequestor contactForm;
        LogicContact contactEdit;
        Dictionary<string, string> EditContact = new Dictionary<string, string>();
        private void GetSringLabel()
        {

            EditContact["FirstName"] = firstNameValue.Text;
            EditContact["LastName"] = lastNameValue.Text;
            EditContact["BirthDate"] = birthDateValue.Text;
            EditContact["CellPhone"] = cellPhoneValue.Text;
            EditContact["HomePhone"] = homePhoneValue.Text;
            EditContact["OfficePhone"] = officePhoneValue.Text;
            EditContact["EmailAddress"] = emailAddressValue.Text;
            EditContact["Organization"] = OrganizationValue.Text;
            EditContact["Position"] = PositionValue.Text;
            EditContact["Message"] = "";

        }

        ///     Конструктор для редактирования контактной формы
        /// </summary>
        /// <param name="contact">
        ///     Принимает объект интерфейса запрашивающего
        /// </param>
        public EditContactForm(IContactRequestor contact)
        {
            InitializeComponent();
            contactForm = contact;                
        }

        public Person ContactEdit { get; set; }

        /// <summary>
        ///     Загружает форму при заполнении полей информацией
        /// </summary>
        private void EditContactForm_Load(object sender, EventArgs e)
        {
            LoadFields(ContactEdit);           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contact"></param>
        public void LoadFields(Person contact)
        {
            firstNameValue.Text = contact.FirstName;
            lastNameValue.Text = contact.LastName;
            birthDateValue.Text = contact.BirthDate;
            cellPhoneValue.Text = contact.CellPhone;
            homePhoneValue.Text = contact.HomePhone;
            officePhoneValue.Text = contact.OfficePhone;
            emailAddressValue.Text = contact.EmailAddress;
            OrganizationValue.Text = contact.Organization;
            PositionValue.Text = contact.Position;
        }

        /// <summary>
        ///     Создает запись контакта в базе данных
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            contactEdit = new LogicContact(contactForm);
            bool res = contactEdit.EditContactForm(EditContact);
            if (res)
                this.Close();
            else
            {
                messageLbl.Visible = true;
                messageLbl.Text = EditContact["Message"];
            }
        }

        /// <summary>
        ///     Закрывает Форму Создания Контакта
        /// </summary>
        private void CancelExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Сбрасывает все поля на пустые
        /// </summary>
        private void ClearEditContactForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearContactForm();
        }

        private void ClearContactForm()
        {
            firstNameValue.Text = "";
            lastNameValue.Text = "";
            birthDateValue.Text = "";
            cellPhoneValue.Text = "";
            homePhoneValue.Text = "";
            officePhoneValue.Text = "";
            emailAddressValue.Text = "";
            OrganizationValue.Text = "";
            PositionValue.Text = "";
        }
    }
}