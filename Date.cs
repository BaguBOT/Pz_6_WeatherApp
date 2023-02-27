namespace studentApp {

    internal class Atest
    {
        private int _Semester;
        private subject  _subject;
        private Student _student;
        private atessst _da;
        private int _garde;

        public int Semester {
            get => _Semester;
        }     
        private Student Student
        {
            get => _student;
        }
        public string surname {
            get { return Student != null ? Student.surname : "Не назначено"; }
        }
        public string Name {
            get { return Student != null ? Student.Name : "Не назначено"; }
        }
        public string fatherland {
            get { return Student != null ? Student.fatherland : "Не назначено"; }
        }
        private subject Subject {
            get => _subject;
        }
        private atessst DA {
            get => _da;
        }
        public int Garde {
            get => _garde;
        }

        public string Atesst {
            get { return Subject != null ? DA.Da : "Не назначено"; }
        }
        public string SubjectName {
            get { return Subject != null ? Subject.Name : "Не назначено"; }
        }

        

        public Atest(int Semester, Student Fuo, subject subjet, atessst Atesst,int garde)
        {
            _Semester = Semester; 
            _student = Fuo;
            _subject = subjet;
            _da = Atesst;
            _garde = garde;
        }


    }
}
