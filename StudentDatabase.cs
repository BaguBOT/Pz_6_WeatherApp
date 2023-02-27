using System;
using System.Collections.Generic;

namespace studentApp {
    public class StudentDatabase
    {
        private Random _random = new Random();
        private int RandomInt
        {
            get => _random.Next(1, 9);
        }
        private int Randomgard {
            get => _random.Next(2, 6);
        }
        internal List<Atest> Atest { get; private set; }

        public void Initialize()
        {
            Atest = new List<Atest>
            {
                new Atest(RandomInt, new Student("Лазарева","Борислава","Вадимовна"), new subject("Математика"),new atessst ("da"),Randomgard),
                new Atest(RandomInt, new Student("Копылова","Варвара ","-"), new subject("Русский язык"),new atessst ("da"),Randomgard),
                new Atest(RandomInt, new Student("Рогов","Май","Русланович"), new subject("Математика"),new atessst ("da"),Randomgard),
                new Atest(RandomInt, new Student("Михеев","Иннокентий","Максович"), new subject("Математика"),new atessst ("net"),Randomgard)
              
            };
        }
    }
}