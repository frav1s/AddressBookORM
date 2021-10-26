using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

namespace AddressBookService
{
    public class LogicContact
    {
        private Form contactForm;
        private readonly IContactRequestor _contact;
        private readonly EfGenericRepository<Person> q = new EfGenericRepository<Person>(new AddressBookDbContext());
        public LogicContact(IContactRequestor contact, Form _form)
        {
            _contact = contact;
            contactForm = _form;
            //ContactForm();
        }

        public void LoadFields(Person contact)
        {
            contactForm.Controls.Find("firstNameValue", true).FirstOrDefault().Text = contact.FirstName;
            contactForm.Controls.Find("lastNameValue", true).FirstOrDefault().Text = contact.LastName;
            contactForm.Controls.Find("birthDateValue", true).FirstOrDefault().Text = contact.BirthDate;
            contactForm.Controls.Find("cellPhoneValue", true).FirstOrDefault().Text = contact.CellPhone;
            contactForm.Controls.Find("homePhoneValue", true).FirstOrDefault().Text = contact.HomePhone;
            contactForm.Controls.Find("officePhoneValue", true).FirstOrDefault().Text = contact.OfficePhone;;
            contactForm.Controls.Find("emailAddressValue", true).FirstOrDefault().Text = contact.EmailAddress;
            contactForm.Controls.Find("OrganizationValue", true).FirstOrDefault().Text = contact.Organization;
            contactForm.Controls.Find("PositionValue", true).FirstOrDefault().Text = contact.Position;
        }

        public void ContactForm()
        {
            var p = new Person();
            ValidationModel validated;
            
            p.FirstName = contactForm.Controls.Find("firstNameValue", true).FirstOrDefault().Text;
            p.LastName = contactForm.Controls.Find("lastNameValue", true).FirstOrDefault().Text;
            p.BirthDate = contactForm.Controls.Find("birthDateValue", true).FirstOrDefault().Text;
            p.CellPhone = contactForm.Controls.Find("cellPhoneValue", true).FirstOrDefault().Text;
            p.HomePhone = contactForm.Controls.Find("homePhoneValue", true).FirstOrDefault().Text;
            p.OfficePhone = contactForm.Controls.Find("officePhoneValue", true).FirstOrDefault().Text;
            p.EmailAddress = contactForm.Controls.Find("emailAddressValue", true).FirstOrDefault().Text;
            p.Organization = contactForm.Controls.Find("OrganizationValue", true).FirstOrDefault().Text;
            p.Position = contactForm.Controls.Find("PositionValue", true).FirstOrDefault().Text;


            validated = Validation.ValidateForm(p);

            if (validated.Result)
            {
                if(contactForm.Name == "EditContactForm")
                    q.Update(p);
                if(contactForm.Name == "CreateContactForm")
                    q.Add(p);
                _contact.ContactComplete(p);
                contactForm.Close();
            }
            else
            {
                contactForm.Controls.Find("messageLbl", true).FirstOrDefault().Visible = true;
                contactForm.Controls.Find("messageLbl", true).FirstOrDefault().Text = validated.Message;
            }
        }

        public void ClearContactForm()
        {
            contactForm.Controls.Find("firstNameValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("lastNameValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("birthDateValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("cellPhoneValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("homePhoneValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("officePhoneValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("emailAddressValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("OrganizationValue", true).FirstOrDefault().Text = "";
            contactForm.Controls.Find("PositionValue", true).FirstOrDefault().Text = "";
        }
    } 
 
}
