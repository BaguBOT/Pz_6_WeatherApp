namespace studentApp
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private string _fatherland;

        public string surname { 
            get => _surname;
            private set => _surname = value;
        }


        public string fatherland 
            {
            get => _fatherland;
set => _fatherland = value;
        }


        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Student(string surname,string name,string fatherland)
        {
          _surname = surname;
            _name = name;
            _fatherland = fatherland;
        }
    }
}
