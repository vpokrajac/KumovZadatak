using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Faculty.Model.Enum;

namespace Faculty.Model
{
   
    public class Student : Person
    {
        public Student(string indexNumber, string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)

        {
            listOfexams = new List<Enrollment>();
            this.indexNumber = string.Format("{0}/{1}", int.Parse(indexNumber), DateTime.Today.Year);
        }

        private string indexNumber;
     
        public string IndexNumber
        {
            get { return indexNumber; }
            set { indexNumber = value; }
        }



        List<Enrollment> listOfexams;

        public List<Enrollment> ListOfExams
        {
            get { return listOfexams; }
            set { listOfexams = value; }
        }
        private double averageMark;
        public double AverageMark
        {
            get {
                double ocena = 0;
                foreach (Enrollment enrollment in listOfexams)
                {
                    ocena += Convert.ToInt32(enrollment.Mark);
                }
                averageMark=ocena/listOfexams.Count;
                return averageMark;
                }
        }


        public Status Status { get; set; }

        public Student()
        {
           
            Status = Status.Regular;

        }

        public override bool IsValid()
        {
            base.IsValid();
            string[] indexNumberFormat = indexNumber.Split('/');
            int firstPartOfIndexNumber;
            bool isNumerical = int.TryParse(indexNumberFormat[0], out firstPartOfIndexNumber);//da li sadrzi integer
            string date = indexNumberFormat[1];

            if (GetAge() > 16 && isNumerical == true && date==DateTime.Today.Year.ToString()) 
            {
                return true;
            }
            return false;
        }
      
        public override string ToString()
        {
            return string.Format("{0}\nIndex number:{1}", base.ToString(), indexNumber);
        }

       
    }
}
