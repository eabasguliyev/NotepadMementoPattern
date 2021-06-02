using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NotepadMementoPattern.Annotations;

namespace NotepadMementoPattern.Entities
{
    public class Editor:INotifyPropertyChanged
    {
        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public Snapshot CreateSnapshot()
        {
            return new Snapshot(Text);
        }

        public void Restore(ISnapshot snapshot)
        {
            if (!(snapshot is Snapshot))
                throw new InvalidOperationException("Invalid snapshot instance.");

            Text = snapshot.GetState();
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}