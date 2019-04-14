using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.Model
{
    public enum Status
    {
        Regular, [Description("Distance learning")]
        distanceLearning, Graduated
    }
    public class Student : Person
    {
        private string indexNumber;
     

        public string IndexNumber
        {
            get { return indexNumber; }
            set { indexNumber = value; }
        }

   
       

        private List<Enrollment> exams;

        public List<Enrollment> Exams
        {
            get { return exams; }
            set { exams = value; }
        }

        private double averageMark;


        public double AverageMark
        {
            get { return averageMark; }
        }


        private Status status;

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public Student()
        {
            exams = new List<Enrollment>();
            status = Status.Regular;

        }

        public Student(string indexNumber, string firstName, string lastName, DateTime dateOfBirth):base(firstName, lastName, dateOfBirth)

        {
            this.indexNumber = string.Format("{0}/{1}", int.Parse(indexNumber), DateTime.Today.Year);
        }

        public override bool IsValid()
        {
            
            base.IsValid();
            if (GetAge() < 16)
            {
                return false;
            }
            return true;
        }
      
        public override string ToString()
        {
            return string.Format("{0}\nIndex number:{1}", base.ToString(), indexNumber);
        }
    }
}
