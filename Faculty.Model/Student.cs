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
            get { return averageMark; }
        }
        public Status Status { get; set; }

        public Student()
        {
           
            Status = Status.Regular;

        }

        public Student(string indexNumber, string firstName, string lastName, DateTime dateOfBirth):base(firstName, lastName, dateOfBirth)

        {
            listOfexams = new List<Enrollment>();
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

        public double AverageMark2()
        {
            int brojac = 0;
            double ocena = 0;
      
            foreach (Enrollment enroll in listOfexams) 
            {
                if (Convert.ToInt32(enroll.Mark) > 5 && Convert.ToInt32(enroll.Mark)<11)
                {
                    ocena += (int) enroll.Mark;
                    brojac++;
                }
                continue;

            }
           double prosecnaOcena = ocena / brojac;
            return prosecnaOcena;
         

           
        }

        public int GetPassedExams()
        {
            int brojac = 0;
            foreach (Enrollment enroll in listOfexams)
            {

                if (Convert.ToInt32(enroll.Mark) > 5)
                {
                    brojac++;
                }

            }

            return brojac;
        }

        public void IspisiIspite()
        {
            foreach (Enrollment enrollment in listOfexams)
            {
                Console.WriteLine(enrollment.Exam.ExamDate.ToShortDateString()+" "+enrollment.Student.FirstName+" "+ enrollment.Student.LastName+" "+enrollment.Exam.Course.Title+" "+(int)enrollment.Mark);
            }
        }

        public int GetPassedExamsEnum()
        {
            int broj = 0;
            foreach (Enrollment enrollment in ListOfExams)
            {
                if (enrollment.Passed == true)
                {
                    broj++;
                }
            }
            return broj;
        }
       
    }
}
