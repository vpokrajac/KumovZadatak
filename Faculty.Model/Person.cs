using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.Model
{
    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = Convert.ToDateTime(value); }
        }

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {

            return string.Format("First Name: {0}\nLast Name: {1}\n{2} years old", firstName, lastName, GetAge());
        }

        public int GetAge()
        {
            return DateTime.Today.Year - dateOfBirth.Year;
        }

        public virtual bool IsValid()
        {
            if (firstName == null || firstName == "" || firstName == " "
                && lastName == null || lastName == "" || lastName == " ")
            {
                return false;
            }

            return true;
        }
    }
}
