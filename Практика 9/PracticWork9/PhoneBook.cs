using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork9
{
    abstract public class PhoneBook
    {
        private string name;
        private int number;
        public string Name { get { return name; } }
        public int Number { get { return number; } }

        abstract public Phone GenerateNote(string n, int p);
    }

    public class PersonCreate : PhoneBook
    {
        public override Phone GenerateNote(string n, int p)
        {
            Person person = new Person(n, p);
            return person;
        }
    }

    public class InstitutionCreate : PhoneBook
    {
        public override Phone GenerateNote(string n, int p)
        {
            Institution institution = new Institution(n, p);
            return institution;
        }
    }

    public class IndividualCreate : PhoneBook
    {
        public override Phone GenerateNote(string n, int p)
        {
            Individual individual = new Individual(n, p);
            return individual;
        }
    }
}
