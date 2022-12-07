using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_vs
{
    internal class Teacher
    {
        public string Name;
        public string Status;

        public void Checksubject(string sub)
        {
            if (sub == "Math")
            {
                Random random = new Random();
                var rnd = random.Next();

                var rnd1 = random.Next();
                Console.WriteLine(rnd + rnd1);
            }
            else if (sub == "chemistry")
            {
                Console.WriteLine("H2O");
            }
            else if (sub == "English")
            {
                Console.WriteLine("This is good");
            }
            else
            {
                Console.WriteLine("This isn't competent");
            }
        }

    }
}
