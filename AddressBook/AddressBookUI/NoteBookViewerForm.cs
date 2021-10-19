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

        private List<Note> _listOfNotes = new List<Note>();
        private string nameOfEditedNote;
    }
}
