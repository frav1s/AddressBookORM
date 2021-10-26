using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using AddressBookLibrary.Validation;
using AddressBookLibrary;
using System;
using System.Windows.Forms;
using AddressBookService;

namespace AddressBookUI
{
    public partial class EditContactForm : Form
    {
        private readonly IContactRequestor contactForm;
        private readonly EfGenericRepository<Person> q = new EfGenericRepository<Person>(new AddressBookDbContext());
        LogicContact contactEdit;
        ///     Конструктор для редактирования контактной формы
        /// </summary>
        /// <param name="contact">
        ///     Принимает объект интерфейса запрашивающего
        /// </param>
        public EditContactForm(IContactRequestor contact)
        {
            InitializeComponent();
            contactForm = contact;
            contactEdit = new LogicContact(contactForm, this);
        }

        public Person ContactEdit { get; set; }

        /// <summary>
        ///     Загружает форму при заполнении полей информацией
        /// </summary>
        private void EditContactForm_Load(object sender, EventArgs e)
        {
            contactEdit.LoadFields(ContactEdit);
        }

        /// <summary>
        ///     Создает запись контакта в базе данных
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            contactEdit.ContactForm();
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
            contactEdit.ClearContactForm();
        }
    }
}