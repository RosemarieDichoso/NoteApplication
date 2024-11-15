using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApplication.Controllers;
using NoteApplication.DAO;
using NoteApplication.Data;
using NoteApplication.Models;
using NoteApplication.Services;

namespace NoteApplication.Forms
{
    public partial class UpdateNoteForm : Form
    {
        private readonly NoteController _noteController;
        public event Action<NoteItem> NoteUpdated;
        private NoteItem _note;

        public UpdateNoteForm(NoteItem noteItem)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NoteRepository(context);
            var noteService = new NoteService(noteRepository);
            _noteController = new NoteController(noteService);

            _note = noteItem;
            PopulateFormFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noteTitle = txtNoteTitle.Text;
            string noteContent = rtxtNoteContent.Text;

            _note.NoteTitle = noteTitle;
            _note.NoteContent = noteContent;
            _note.Date = DateTime.Now;

            NoteUpdated?.Invoke(_note);
            this.Close();
        }


        private void PopulateFormFields()
        {
            txtNoteTitle.Text = _note.NoteTitle;
            rtxtNoteContent.Text = _note.NoteContent;
            lblDate.Text = $"Last Updated: {_note.Date:yyyy-MM-dd HH:mm:ss}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exitUpdateForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
