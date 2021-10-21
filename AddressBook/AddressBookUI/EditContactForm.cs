using System;
using System.Windows.Forms;
using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using AddressBookLibrary.Validation;

namespace AddressBookUI
{
    public partial class EditContactForm : Form
    {
        private readonly IContactRequestor contactForm;
        private readonly EfGenericRepository<Person> q = new EfGenericRepository<Person>(new AddressBookDbContext());

        /// <summary>
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
        ///     Вводит информацию в текстовые поля формы
        /// </summary>
        /// <param name="contact">
        ///     Объект контактной модели
        /// </param>
        private void LoadFields(Person contact)
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
            var p = ContactEdit;
            ValidationModel validated;

            p.FirstName = firstNameValue.Text;
            p.LastName = lastNameValue.Text;
            p.BirthDate = birthDateValue.Text;
            p.CellPhone = cellPhoneValue.Text;
            p.HomePhone = homePhoneValue.Text;
            p.OfficePhone = officePhoneValue.Text;
            p.EmailAddress = emailAddressValue.Text;
            p.Organization = OrganizationValue.Text;
            p.Position = PositionValue.Text;

            validated = Validation.ValidateForm(p);

            if (validated.Result)
            {
                q.Update(p);
                contactForm.ContactComplete(p);
                Close();
            }
            else
            {
                messageLbl.Visible = true;
                messageLbl.Text = validated.Message;
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