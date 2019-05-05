using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel;

namespace Faculty.Model
{

   
   public class Exam
    {
        public Exam(Course course, DateTime examDate)
        {
            this.course = course;
            this.examDate = examDate;
            listOfStudents = new List<Student>(); //sam inicijalizovao
        }

        private Course course;

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        private DateTime examDate;

        public DateTime ExamDate

        {
            get { return examDate; }
            set { examDate = value; }
        }

        private List<Student> listOfStudents;

        public List<Student> ListOfStudents

        {
            get { return listOfStudents; }
            set { listOfStudents = value; }
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", course, examDate);
        }

        public bool Apply(Student student)
        {
         
            foreach (Student currentStudent in listOfStudents)
            {
                if(student.IndexNumber == currentStudent.IndexNumber)
                {
                    return false; 
                }
      
            }
            listOfStudents.Add(student);
            return true;


        }
    }
}
