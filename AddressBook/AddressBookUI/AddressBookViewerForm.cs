using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AddressBookUI
{
    public partial class AddressBookViewerForm : Form, IContactRequestor
    {
        private readonly List<Note> _sortedNotes = new List<Note>();
        private readonly List<Panel> noteList = new List<Panel>();

        private readonly EfGenericRepository<Note> NoteRepository =
            new EfGenericRepository<Note>(new AddressBookDbContext());

        private readonly EfGenericRepository<Person> PersonRepository =
            new EfGenericRepository<Person>(new AddressBookDbContext());

        /// <summary>
        ///     _knownContacts заполненный FillListBox() методом; _sortedContacts временный список
        /// </summary>
        private List<Person> _knownContacts = new List<Person>();

        private List<Note> _listOfNotes = new List<Note>();

        private List<Person> _sortedContacts = new List<Person>();
        private string nameOfEditedNote;

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
            _knownContacts = PersonRepository.GetAll();
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = _knownContacts;
            ContactListBox.DisplayMember = "FullNameLast";
        }

        /// <summary>
        ///     Метод сортировки отображает записи по возрастанию, заполняет поле списка
        /// </summary>
        private void AscSortListBox()
        {
            // todo: копипаста
            _sortedContacts = _knownContacts.OrderBy(x => x.FullNameLast).ToList();
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = _sortedContacts;
            ContactListBox.DisplayMember = "FullNameLast";
            _sortedContacts.Clear();
        }

        /// <summary>
        ///     Метод сортировки отображает записи по убыванию, заполняет поле списка
        /// </summary>
        private void DesSortListBox()
        {
            _sortedContacts = _knownContacts.OrderByDescending(x => x.FullNameLast).ToList();
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
                PersonRepository.Remove(contact);
                _knownContacts = PersonRepository.GetAll();
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
            AscSortListBox();
        }

        /// <summary>
        ///     Вызывает DescSortListBox()
        /// </summary>
        private void ZAButton_Click(object sender, EventArgs e)
        {
            DesSortListBox();
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        ///     Загружает заметки из БД
        /// </summary>
        private void LoadNote()
        {
            _listOfNotes = NoteRepository.GetAll();
        }

        private void DrawNotes()
        {
            var maxOfNote = _listOfNotes.Count;

            for (var countOfNote = 0; countOfNote < maxOfNote; countOfNote++)
                noteList.Add(GetBoxNote(_listOfNotes[countOfNote], countOfNote));
        }

        /// <summary>
        ///     Добавляет новую заметку
        /// </summary>
        private void AddNewNote(object sender, EventArgs e)
        {
            var indexOfNote = _listOfNotes.Count;

            var a = new Note
            {
                _date = DateTime.Now.ToString(),
                _note = "Введите запись"
            };

            _listOfNotes.Add(a);
            NoteRepository.Add(a);

            noteList.Add(GetBoxNote(a, indexOfNote));
        }

        /// <summary>
        ///     Добавляет окно записки в форму
        /// </summary>
        /// <param name="_text">
        ///     Текст записки
        /// </param>
        public Panel GetBoxNote(Note note, int _id)
        {
            Panel _boxPanel;
            Label _labletextNote;
            Label _labledateNote;

            _boxPanel = new Panel();
            _labledateNote = new Label();
            _labletextNote = new Label();

            _boxPanel.Name = "boxNote" + _id;
            _boxPanel.Location = new Point(10, 20 + _id * 120);
            _boxPanel.Size = new Size(400, 100);
            _boxPanel.BackColor = Color.White;

            _labletextNote.Name = "text";
            _labletextNote.ForeColor = Color.Black;
            _labletextNote.Location = new Point(20, 50);
            _labletextNote.Size = new Size(280, 30);
            _labletextNote.AutoSize = false;
            _labletextNote.Text = note._note;
            // _labletextNote.Click += new System.EventHandler(this.ClickEditForLabel);
            _boxPanel.Click += ClickEdit;

            _boxPanel.Controls.Add(_labletextNote);

            _labledateNote.Name = "date";
            _labledateNote.ForeColor = Color.Black;
            _labledateNote.Location = new Point(15, 5);
            _labledateNote.Size = new Size(100, 60);
            _labledateNote.AutoSize = true;
            _labledateNote.Text = note._date;
            // _labledateNote.Click += new System.EventHandler(this.ClickEdit);

            _boxPanel.Controls.Add(_labledateNote);

            panel1.Controls.Add(_boxPanel);

            return _boxPanel;
        }

        public void ClickEdit(object sender, EventArgs e)
        {
            ColorNote();
            var box = (Panel)sender;

            box.BackColor = Color.Gray;

            var textNote = box.Controls.Find("text", true).FirstOrDefault();
            var dateNote = box.Controls.Find("date", true).FirstOrDefault();

            richTextBox1.Text = textNote.Text;

            infoNote.Text = "Заметка от " + dateNote.Text;
            ShowNoteElements();

            nameOfEditedNote = box.Name;
        }

        private void ShowNoteElements()
        {
            infoNote.Show();
            richTextBox1.Show();
            save.Show();
            delete.Show();
        }

        private void HideNoteElements()
        {
            infoNote.Hide();
            richTextBox1.Hide();
            save.Hide();
            delete.Hide();
        }

        private void ColorNote()
        {
            for (var countOfPanel = 0; countOfPanel < noteList.Count; countOfPanel++)
                noteList[countOfPanel].BackColor = Color.White;
        }

        private void SaveEdit(object sender, EventArgs e)
        {
            var savedNote = new Note();
            var editingNoteBox = (Panel)tabPage2.Controls.Find(nameOfEditedNote, true).FirstOrDefault();

            var idNote = noteList.IndexOf(editingNoteBox);

            editingNoteBox.BackColor = Color.White;

            var textOfNote = editingNoteBox.Controls.Find("text", true).FirstOrDefault();
            var dateOfNote = editingNoteBox.Controls.Find("date", true).FirstOrDefault();

            textOfNote.Text = richTextBox1.Text;
            dateOfNote.Text = DateTime.Now.ToString();

            // NoteRepository.Remove(_listOfNotes[idNote]);

            savedNote._note = richTextBox1.Text;
            savedNote._date = DateTime.Now.ToString();

            _listOfNotes.Add(savedNote);
            NoteRepository.Add(savedNote);

            ClearNotesBox();
            _listOfNotes.Sort(SortNewNote);

            DrawNotes();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var editingNoteBox = (Panel)tabPage2.Controls.Find(nameOfEditedNote, true).FirstOrDefault();

            var idNote = noteList.IndexOf(editingNoteBox);

            ClearNotesBox();

            var deletedNote = _listOfNotes[idNote];

            NoteRepository.Remove(deletedNote);

            _listOfNotes.RemoveAt(idNote);

            DrawNotes();

            HideNoteElements();
        }

        private void ClearNotesBox()
        {
            var maxOfNoteBox = noteList.Count;

            for (var countOfNoteBox = 0; countOfNoteBox < maxOfNoteBox; countOfNoteBox++)
            {
                var deletedNote = (Panel)tabPage2.Controls.Find(noteList[countOfNoteBox].Name, true).FirstOrDefault();
                panel1.Controls.Remove(deletedNote);
            }

            noteList.Clear();
        }

        private void ShowPanelSearch()
        {
            panel1.Location = new Point(13, 163);
            button4.Show();
            label1.Show();
        }

        private void ExitSearch(object sender, EventArgs e)
        {
            LoadNote();
            DrawNotes();
            panel1.Location = new Point(13, 123);
            button4.Hide();
            label1.Hide();
        }

        private void ShowNewNotes(object sender, EventArgs e)
        {
            _listOfNotes.Sort(SortNewNote);
            ClearNotesBox();
            DrawNotes();
            ShowPanelSearch();
        }

        private void ShowOldNotes(object sender, EventArgs e)
        {
            _listOfNotes.Sort(SortOldNote);
            ClearNotesBox();
            DrawNotes();
            ShowPanelSearch();
        }

        private void FindNoteAtThisDate(object sender, EventArgs e)
        {
            LoadNote();
            ClearNotesBox();
            _sortedNotes.Clear();

            var param = dateTimePicker1.Value;
            for (var countOfNote = 0; countOfNote < _listOfNotes.Count; countOfNote++)
                if (DateTime.Parse(_listOfNotes[countOfNote]._date).Date == param.Date)
                    _sortedNotes.Add(_listOfNotes[countOfNote]);
            _listOfNotes.Clear();
            _listOfNotes = _sortedNotes;

            DrawNotes();
            ShowPanelSearch();
        }

        private int SortNewNote(Note s1, Note s2)
        {
            var t1 = DateTime.Parse(s1._date);
            var t2 = DateTime.Parse(s2._date);
            if (t2 > t1)
                return 1;
            if (t2 < t1)
                return -1;
            return 0;
        }

        private int SortOldNote(Note s1, Note s2)
        {
            var t1 = DateTime.Parse(s1._date);
            var t2 = DateTime.Parse(s2._date);
            if (t2 > t1)
                return -1;
            if (t2 < t1)
                return 1;
            return 0;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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