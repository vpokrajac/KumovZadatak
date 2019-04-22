using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.Model
{
   public class Professor : Person
    {
        
        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",FirstName, LastName, employeeId); //da li se ovako poziva Bog me ubio
        }

        public Professor(string employeeId, string firstName, string lastName, DateTime dateOfBirth):base(firstName, lastName, dateOfBirth)
        {
            this.employeeId = employeeId;
        }
    }
}
