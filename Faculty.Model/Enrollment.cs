using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.Model
{
    public enum Mark { one=1, two, three, four, five, six, seven, eight, nine, ten}

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

        private Mark? mark;

        public Mark? Markchrome 
        {
            get { return mark; }
            set { mark = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Exam.ToString(), mark); //valja li ova? 
        }

        public Enrollment(Exam exam, Student s)
        {
            this.exam = exam;
            this.student = s;
        }
    }
}
