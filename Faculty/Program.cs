using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculty.Model;
using Faculty.Model.Enum;
using static System.Net.Mime.MediaTypeNames;

namespace Faculty
{
    class Program
    {
        //foreach limit? StudentOne se gazi, lista ostaje?
        static List<Student> Students = new List<Student>();
        static List<Course> Courses = new List<Course>();
        static List<Professor> Professors = new List<Professor>();
        static List<Exam> Exams = new List<Exam>();

        static void Main(string[] args)
        {


            #region Professors
            Professor professorOne = new Professor("10", "Slobodan", "Jankovic", DateTime.Parse("12/12/1952"));
            Professor professorTwo = new Professor("22", "Vlado", "Pazin", DateTime.Parse("10/12/1970"));
            Professor professorThree = new Professor("13", "Zivko", "Knezevic", DateTime.Parse("12/12/1960"));
            #endregion

            #region Courses
            Course courseOne = new Course("Matematika1", "Prva godina", professorOne);
            Course courseTwo = new Course("Matematika2", "Prva godina", professorOne);
            Course courseThree = new Course("Srpski", "Prva godina", professorTwo);
            Course courseFour = new Course("Engleski", "Druga godina", professorThree);
            Course courseFive = new Course("Fizika", "Druga godina", professorThree);
            #endregion

            #region Exams
            Exam exam = new Exam(courseOne, DateTime.Parse("12/11/2018"));
            Exam exam2 = new Exam(courseOne, DateTime.Parse("12/11/2018"));
            Exam exam3 = new Exam(courseThree, DateTime.Parse("10/11/2018"));
            Exam exam4 = new Exam(courseFour, DateTime.Parse("11/11/2018"));
            Exam exam5 = new Exam(courseTwo, DateTime.Parse("10/11/2018"));
            Exam exam6 = new Exam(courseFive, DateTime.Parse("10/11/2018"));


//            var bookList = new List<Book>()
//{
//  new Book(),
//  new Book(), //da ne bih kucao, kako da znam koji je koji ispit ako pravim na ovakav nacin?
//  new Book()
//};
            #endregion

            bool entry = true;
            while (true)
            {
                Pokreni();
                int rezultat = int.Parse(Console.ReadLine());//kad radi parse isto pretvara u int, samo mozda ne po default u int32???
                switch (rezultat)
                {
                    case 1:
                        if (Students.Count != 0)
                            foreach (Student student in Students)
                            {
                                Console.WriteLine(student.ToString());
                            }

                        else
                        {
                            Console.WriteLine("List of students is empty!");
                        }
                        break;
                    case 2:

                        Console.WriteLine("Fill required information");

                        Console.WriteLine("Enter name of the student");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter surname of the student");
                        string surname = Console.ReadLine();

                        Console.WriteLine("Enter index number");
                        string indexNumber = Console.ReadLine();

                        Console.WriteLine("Enter date of birth (mm/dd/yyyy)");
                        string dateOfBirth = Console.ReadLine();

                        Student studentOne = new Student(indexNumber, name, surname, DateTime.Parse(dateOfBirth));
                        studentOne.IsValid();
                        Students.Add(studentOne);
                        //Enrollment enrollment = new Enrollment(exam2, studentOne, Mark.seven);
                        //Enrollment enrollment2 = new Enrollment(exam4, studentOne, Mark.eight);
                        //studentOne.ListOfExams.Add(enrollment);
                        //studentOne.ListOfExams.Add(enrollment2);
                        //Console.WriteLine(studentOne.AverageMark);
                        Console.WriteLine("Student is added properly!");//pitati kuma
                        break;
                    case 3:

                        Console.WriteLine("Enter index number:");
                        string indexNumberToDelete = string.Format("{0}/{1}", Console.ReadLine(), DateTime.Today.Year);
                        foreach (Student student in Students)
                        {
                            if (indexNumberToDelete==student.IndexNumber)
                            {
                                Students.Remove(student);
                                Console.WriteLine("Student is properly deleted!");
                                break;
                            }
                        }
                        
                        break;

                    //case 4:
                    //    student2.IspisiIspite();
                    //    Console.WriteLine("Ukupan broj polozenih ispita studenta je: " + student2.GetPassedExamsEnum());
                    //    Console.WriteLine("Prosecan broj ocene studenta je : " + student2.AverageMark2());
                    //    break;
                    case 5:
                        Environment.Exit(-1);
                        break;
                }

            }

        }
        public static void Pokreni()
        {
            Console.WriteLine("1.Show all students\n2.Add new Student\n3.Delete Student\n4.GetPassedExamas\n5.Exit Program\nChoose from 1 to 5...");
        }

       public static void ObrisiStudenta(string indexNumber)
        {
            foreach (Student student in Students) //kume, ukljuci se, dje gresim - ACO IZ PAZOVE
            {
                if (student.IndexNumber == indexNumber)
                {
                    Students.Remove(student);
                    break;
                }
            }
        }

    }
}
