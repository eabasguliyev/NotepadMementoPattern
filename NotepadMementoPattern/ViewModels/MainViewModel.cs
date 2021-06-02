using NotepadMementoPattern.Commands;
using NotepadMementoPattern.Entities;
using NotepadMementoPattern.Models;

namespace NotepadMementoPattern.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public Editor Editor { get; set; }
        private History _history;

        public SaveCommand SaveCommand { get; set; }
        public BackCommand BackCommand { get; set; }
        public EditorCommand ForwardCommand { get; set; }

        public MainViewModel()
        {
            Editor = new Editor();
            _history = new History(Editor);

            SaveCommand = new SaveCommand(_history);
            BackCommand = new BackCommand(_history);
            ForwardCommand = new ForwardCommand(_history);
        }
    }
}