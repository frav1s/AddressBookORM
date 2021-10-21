using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AddressBookLibrary.DatabaseContext;
using AddressBookLibrary.Model;
using AddressBookLibrary.Repository;

namespace AddressBookUI
{
    public partial class AddressBookViewerForm : Form, IContactRequestor
    {
        private readonly List<Note> _sortedNotes = new List<Note>();
        private readonly List<Panel> noteList = new List<Panel>();

        private readonly EfGenericRepository<Note> NoteRepository =
    new EfGenericRepository<Note>(new AddressBookDbContext());

        private List<Note> _listOfNotes = new List<Note>();
        private string nameOfEditedNote;

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
        /// <summary>
        ///    Поиск записок заданной даты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///     Лябда функция сортировки Note по возрастанию даты
        /// </summary>
        /// <param name="s1">Первая записка</param>
        /// <param name="s2">Вторая записка</param>
        /// <returns>Возвращает -1,0,1 в зависимости от результата сравнения</returns>
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
        /// <summary>
        ///     Лябда функция сортировки Note по убыванию даты
        /// </summary>
        /// <param name="s1">Первая записка</param>
        /// <param name="s2">Вторая записка</param>
        /// <returns>Возвращает -1,0,1 в зависимости от результата сравнения</returns>
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
    }
}
