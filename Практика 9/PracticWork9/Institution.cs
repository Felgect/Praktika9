using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork9
{
    internal class Institution : Phone
    {
        private string name;
        private int number;

        public Institution(string name, int number) { this.name = name; this.number = number; }

        public string GetInfo()
        {
            return "Образовательное учреждение: " + name + "\nНомер: " + number + "\n";
        }
    }
}
