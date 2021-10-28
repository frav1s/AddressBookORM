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
            var person = new Person();          

            person.FirstName = labelForm["FirstName"];
            person.LastName = labelForm["LastName"];
            person.BirthDate = labelForm["BirthDate"];
            person.CellPhone = labelForm["CellPhone"];
            person.HomePhone = labelForm["HomePhone"];
            person.OfficePhone = labelForm["OfficePhone"];
            person.EmailAddress = labelForm["EmailAddress"];
            person.Organization = labelForm["Organization"];
            person.Position = labelForm["Position"];

            return person;
        }
        private ValidationModel ValidateContactForm(Person p)
        {
            ValidationModel validated;
            return Validation.ValidateForm(p);
        }
        public bool CreateContactForm(Dictionary<string, string> labelForm)
        {
            var person = ContactForm(labelForm);
          
            if (ValidateContactForm(person).Result)
            {
                repository.Add(person);
                _contact.ContactComplete(person);
                //contactForm.Close();
                return true;
            }
            else
            {
                labelForm["Message"] = ValidateContactForm(person).Message;
                return false;
            }
        }
        public bool EditContactForm(Dictionary<string, string> labelForm)
        {
            var person = ContactForm(labelForm);

            if (ValidateContactForm(person).Result)
            {
                repository.Update(person);
                _contact.ContactComplete(person);
                //contactForm.Close();
                return true;
            }
            else
            {
                labelForm["Message"] = ValidateContactForm(person).Message;
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
