using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_vs
{
    public class Student
    {
        public string Name;
        public int Age;
        public int Year;
        public string Subjects()
        {
            Random random = new Random();

            var subject = new string[] { "Math", "chemistry", "English" };

            var rnd = random.Next() % 3;

            var subject1 = subject[rnd];

            return subject1;


        }
        public int LeftTime()
        {
            return 4 - (DateTime.Now.Year - this.Year);
        }
    }
}
