namespace studentApp
{
    internal class subject {
        private string _name;

    
        public string Name {
            get => _name;
            private set => _name = value;
        }

        public subject( string name) {

            _name = name;
        }
    }
}
