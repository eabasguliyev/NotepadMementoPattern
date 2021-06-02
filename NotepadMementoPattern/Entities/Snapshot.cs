namespace NotepadMementoPattern.Entities
{
    public class Snapshot:ISnapshot
    {
        private string _state;

        public Snapshot(string state)
        {
            _state = state;
        }

        public string GetState() => _state;
    }
}