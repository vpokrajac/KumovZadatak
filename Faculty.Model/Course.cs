using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.Model
{
   public class Course
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private Professor professor;

        public Professor Professor
        {
            get { return professor; }
            set { professor = value; }
        }

        public Course(string title, string description, Professor proffessor)
        {
            this.title = title;
            this.description = description;
            this.professor = proffessor;
        }

    }
}
