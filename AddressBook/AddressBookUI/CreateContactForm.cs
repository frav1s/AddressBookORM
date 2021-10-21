using System;
using System.Windows.Forms;
using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using AddressBookLibrary.Validation;

namespace AddressBookUI
{
    public partial class CreateContactForm : Form
    {
        private readonly IContactRequestor contactForm;
        private readonly EfGenericRepository<Person> q = new EfGenericRepository<Person>(new AddressBookDbContext());

        public CreateContactForm(IContactRequestor contact)
        {
            InitializeComponent();
            contactForm = contact;
        }

        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            var p = new Person();
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
                q.Add(p);
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
        ///     Закрывает форму создания контакта
        /// </summary>
        private void CancelExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Сбрасывает все поля на пустые
        /// </summary>
        private void ClearCreateContactForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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