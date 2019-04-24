﻿using System;
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
            get { return passed; }
           set {

                passed = value;
              }
        }

      


        public override string ToString()
        {
            return string.Format("{0}{1}", Exam.ToString(), Mark); //valja li ova? 
        }

        private Mark? mark;

        public Mark? Mark
        {
            get { return mark; }
            set
            {
                mark = value;

                passed = true; //ni ovo ne radi

            }


        }


        public Enrollment(Exam exam, Student s, Mark mark)
        {
            this.exam = exam;
            this.student = s;
            this.mark  = mark;

            
        }

        public Enrollment()
        {
        }

     
    }
}
