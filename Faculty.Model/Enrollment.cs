using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculty.Model.Enum;

namespace Faculty.Model
{
    

   public class Enrollment
    {
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        private Exam exam;

        public Exam Exam
        {
            get { return exam; }
            set { exam = value; }
        }

        private bool? passed;

        public bool? Passed
        {
            get { return Passed; }
            set { Passed = value; }
        }

        public int Ocena { get; set; }


        public override string ToString()
        {
            return string.Format("{0}{1}", Exam.ToString(), Ocena); //valja li ova? 
        }

        private Mark? mark;

        public Mark? Mark
        {
            get { return mark; }
            set { mark = value; }
        }


        public Enrollment(Exam exam, Student s, int ocena)
        {
            this.exam = exam;
            this.student = s;
            this.Ocena = ocena;
        }

        public Enrollment()
        {
        }

     
    }
}
