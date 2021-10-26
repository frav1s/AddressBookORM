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
        private readonly EfGenericRepository<Person> q = new EfGenericRepository<Person>(new AddressBookDbContext());
        LogicContact contactCreate;
        public CreateContactForm(IContactRequestor contact)
        {
            InitializeComponent();
            contactForm = contact;
        }

        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            contactCreate = new LogicContact(contactForm, Form.ActiveForm);
            contactCreate.ContactForm();
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
            contactCreate.ClearContactForm();
        }
    }
}
