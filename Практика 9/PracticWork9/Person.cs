using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork9
{
    public class Person : Phone
    {
        private string name;
        private int number;

        public Person(string name, int number) { this.name = name; this.number = number; }

        public string GetInfo()
        {
            return "Физическое лицо: " + name + "\nНомер: " + number + "\n";
        }
    }
}
