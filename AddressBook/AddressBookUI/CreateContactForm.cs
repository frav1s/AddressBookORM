using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using AddressBookLibrary.Validation;
using AddressBookLibrary;
using AddressBookService;

namespace AddressBookUI
{
    public partial class CreateContactForm : Form
    {
        private readonly IContactRequestor contactForm;
        //private readonly EfGenericRepository<Person> q = new EfGenericRepository<Person>(new AddressBookDbContext());
        LogicContact contactCreate;
        Dictionary<string, string> CreateLabel = new Dictionary<string, string>();
        private void GetSringLabel()
        {
       
            CreateLabel["FirstName"] = firstNameValue.Text;
            CreateLabel["LastName"] = lastNameValue.Text;
            CreateLabel["BirthDate"] = birthDateValue.Text;
            CreateLabel["CellPhone"] = cellPhoneValue.Text;
            CreateLabel["HomePhone"] = homePhoneValue.Text;
            CreateLabel["OfficePhone"] = officePhoneValue.Text;
            CreateLabel["EmailAddress"] = emailAddressValue.Text;
            CreateLabel["Organization"] = OrganizationValue.Text;
            CreateLabel["Position"] = PositionValue.Text;
            CreateLabel["Message"] = "";

        }
        public CreateContactForm(IContactRequestor contact)
        {
            InitializeComponent();          
            contactForm = contact;
        }

        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            GetSringLabel();
            contactCreate = new LogicContact(contactForm);
            bool res = contactCreate.CreateContactForm(CreateLabel);
            if (res)
                this.Close();
            else
            {
                messageLbl.Visible = true;
                messageLbl.Text = CreateLabel["Message"];
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
