using System.Collections.Generic;

namespace NotepadMementoPattern.Entities
{
    public class History
    {
        private Editor _editor;
        private List<Snapshot> _history;

        private int _current;

        public bool CanBack => _current > 0;
        public bool CanForward => _current < _history.Count - 1;

        public History(Editor editor)
        {
            _editor = editor;

            _history = new List<Snapshot>();
            _current = 0;
        }

        public void Backup()
        {
            if (_current < _history.Count - 1)
                _history.RemoveRange(_current + 1, _history.Count - _current - 1);

            _history.Add(_editor.CreateSnapshot());
            _current = _history.Count - 1;
        }

        public void Back()
        {
            if (_current == 0)
                return;

            _editor.Restore(_history[--_current]);

        }

        public void Forward()
        {
            if (_current == _history.Count - 1)
                return;

            _editor.Restore(_history[++_current]);
        }
    }
}