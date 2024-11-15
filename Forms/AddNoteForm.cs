using NoteApplication.Controllers;
using NoteApplication.DAO;
using NoteApplication.Data;
using NoteApplication.Services;

namespace NoteApplication.Forms
{
    public partial class AddNoteForm : Form
    {
        private readonly NoteController _noteController;
        public event Action NoteAdded;
        public AddNoteForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NoteRepository(context);
            var noteService = new NoteService(noteRepository);
            _noteController = new NoteController(noteService);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noteTitle = txtNoteTitle.Text;
            string noteContent = rtxtNoteContent.Text;

            _noteController.AddNote(noteTitle, noteContent);
            MessageBox.Show($"Added Successfully!\nDate: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", "Information");

            //Raise the event to notify the Main Form
            NoteAdded?.Invoke();
            this.Close();
        }

        private void exitAddForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
