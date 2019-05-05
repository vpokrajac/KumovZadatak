using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.Model
{
    public class Person
    {
        public Person()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

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
            set { dateOfBirth = value; }
        }

    
        public override string ToString()
        {

            return string.Format("First Name: {0}\nLast Name: {1}\n{2} years old", firstName, lastName, GetAge());
        }

        public int GetAge()
        {
            int days = (DateTime.Today - dateOfBirth).Days;
            return days / 365;
             }

        public virtual bool IsValid() 
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)
               )
            {
                return false;
            }

            return true;
        }
    }
}
