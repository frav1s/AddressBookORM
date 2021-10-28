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
        private readonly EfGenericRepository<Person> repository = new EfGenericRepository<Person>(new AddressBookDbContext());
        public LogicContact(IContactRequestor contact)
        {
            _contact = contact;
        }
        public LogicContact() { }
        //Dictionary<string,string> label
        private Person ContactForm(Dictionary<string, string> labelForm)
        {
            var p = new Person();          

            p.FirstName = labelForm["FirstName"];
            p.LastName = labelForm["LastName"];
            p.BirthDate = labelForm["BirthDate"];
            p.CellPhone = labelForm["CellPhone"];
            p.HomePhone = labelForm["HomePhone"];
            p.OfficePhone = labelForm["OfficePhone"];
            p.EmailAddress = labelForm["EmailAddress"];
            p.Organization = labelForm["Organization"];
            p.Position = labelForm["Position"];

            return p;
        }
        private ValidationModel ValidateContactForm(Person p)
        {
            ValidationModel validated;
            return Validation.ValidateForm(p);
        }
        public bool CreateContactForm(Dictionary<string, string> labelForm)
        {
            var p = ContactForm(labelForm);
          
            if (ValidateContactForm(p).Result)
            {
                repository.Add(p);
                _contact.ContactComplete(p);
                //contactForm.Close();
                return true;
            }
            else
            {
                labelForm["Message"] = ValidateContactForm(p).Message;
                return false;
            }
        }
        public bool EditContactForm(Dictionary<string, string> labelForm)
        {
            var p = ContactForm(labelForm);

            if (ValidateContactForm(p).Result)
            {
                repository.Update(p);
                _contact.ContactComplete(p);
                //contactForm.Close();
                return true;
            }
            else
            {
                labelForm["Message"] = ValidateContactForm(p).Message;
                return false;
            }
        }

        public void DeleteContact(Person contatc)
        {
            repository.Remove(contatc);
        }

        public List<Person> GetAllContact()
        {
            return repository.GetAll();
        }

    } 
 
}
