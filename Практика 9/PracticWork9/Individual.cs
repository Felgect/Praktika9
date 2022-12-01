using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork9
{
    public class Individual : Phone
    {
        private string name;
        private int number;

        public Individual(string name, int number) { this.name = name; this.number = number; }

        public string GetInfo()
        {
            return "Индивидуальный предприниматель: " + name + "\nНомер: " + number + "\n";
        }
    }
}
