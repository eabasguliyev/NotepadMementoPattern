using System.Windows;
using NotepadMementoPattern.Entities;

namespace NotepadMementoPattern.Commands
{
    public class BackCommand : EditorCommand
    {
        public BackCommand(History history) : base(history)
        {
        }

        public override bool CanExecute(object parameter) => _history.CanBack;

        public override void Execute(object parameter)
        {
            _history.Back();
        }
    }
}