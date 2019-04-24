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
        static List<Student> Students = new List<Student>();
        static List<Professor> Professors = new List<Professor>();
        static List<Exam> Exams = new List<Exam>();
        // itd


        static void Main(string[] args)
        {



            Student student = new Student();
            Console.WriteLine("Unesi neophodne podatke");

            Console.WriteLine("Unesi ime studenta");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesi prezime studenta");
            string prezime = Console.ReadLine();

            Console.WriteLine("Unesi brIndeksa");
            string brIndeksa = Console.ReadLine();

            //int ocena = 0;
            //int brojac = 0;
            //while (brojac < 5)
            //{

            //    Console.WriteLine("Unesi ocenu");

            //    try
            //    {
            //        ocena = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Unesite broj!");
            //        brojac++;
            //    }
            //}

            Console.WriteLine("Unesi ocenu from one to ten");

            Mark mark;
            string ocena = Console.ReadLine().ToUpper();
         

            switch (ocena)
            {
                case "ONE":
                    mark = Mark.one;
                    break;
                case "TWO":
                    mark = Mark.two;
                    break;
                case "THREE":
                    mark = Mark.three;
                    break;
                case "FOUR":
                    mark = Mark.four;
                    break;
                case "FIVE":
                    mark = Mark.five;
                    break;
                case "SIX":
                    mark = Mark.six;
                    break;
                case "SEVEN":
                    mark = Mark.seven;
                    break;
                case "EIGHT":
                    mark = Mark.eight;
                    break;
                case "NINE":
                    mark = Mark.nine;
                    break;
                case "TEN":
                    mark = Mark.ten;
                    break;
                default:
                    mark=Mark.five;//nema smisla, ali moram da deklarisem ovde mark
                    break;
            }

            Console.WriteLine("Unesi datum rodjenjau formatu mm/dd/yyyy");
            string datum = Console.ReadLine();

            Console.WriteLine("Unesi ime profesora");
            string imeProfesora = Console.ReadLine();

            Console.WriteLine("Unesi prezime profesora");
            string prezimeProfesora = Console.ReadLine();

            Console.WriteLine("Unesi datum rodjenjau formatu mm/dd/yyyy");
            string datumProfesora = Console.ReadLine();

            Console.WriteLine("Unesi employeeID");
            string employeeId = Console.ReadLine();

            Professor profesor = new Professor(employeeId, imeProfesora, prezimeProfesora, DateTime.Parse(datumProfesora));
            Professor profesor2 = new Professor("22", "Vlado", "Pazin", DateTime.Parse(datumProfesora));

            Console.WriteLine("Unesi naslov");
            string naslov = Console.ReadLine();

            Console.WriteLine("Unesi opisKursa");
            string opis = Console.ReadLine();

            Console.WriteLine("Unesi datum ispita formatu mm/dd/yyyy");
            string datumIspita = Console.ReadLine();


            Person osoba1 = new Person(ime, prezime, DateTime.Parse(datum));
            
           
            Course course = new Course(naslov, opis, profesor);
            Course course2 = new Course("Mata", "DVA", profesor2);
            Course course3 = new Course("Srpski", "DVA", profesor2);
            Course course4 = new Course("Engleski", "DVA", profesor2);
            Course course5 = new Course("Fizika", "DVA", profesor2);
            Course course6 = new Course("Istorija", "DVA", profesor2);

            Exam exam = new Exam(course, DateTime.Parse(datumIspita));
            Exam exam2 = new Exam(course2, DateTime.Parse(datumIspita));
            Exam exam3 = new Exam(course3, DateTime.Parse(datumIspita));
            Exam exam4 = new Exam(course4, DateTime.Parse(datumIspita));
            Exam exam5 = new Exam(course5, DateTime.Parse(datumIspita));
            Exam exam6 = new Exam(course6, DateTime.Parse(datumIspita));

            Student student2 = new Student(brIndeksa, ime, prezime, DateTime.Parse(datum));
            Student student3 = new Student("133", "Vojkan", "Ilic", DateTime.Parse("12/15/1998"));
            Student student4 = new Student("150", "Lazar", "Minic", DateTime.Parse("12/15/1997"));
            Student student5 = new Student("112", "Stevan", "Ilic", DateTime.Parse("12/15/1996"));
            Students.Add(student);
            Students.Add(student2);
            Students.Add(student3);
            Students.Add(student4);
            Students.Add(student5);



            Enrollment enroll1 = new Enrollment(exam, student, mark);
            Enrollment enroll2 = new Enrollment(exam2, student2, mark);
            Enrollment enroll3 = new Enrollment(exam3, student2, mark);
            Enrollment enroll4 = new Enrollment(exam4, student2, mark);
            Enrollment enroll5 = new Enrollment(exam5, student2, mark);
            Enrollment enroll6 = new Enrollment(exam6, student2, mark);
            Enrollment enroll7 = new Enrollment(exam6, student3, mark);
            Enrollment enroll8 = new Enrollment(exam6, student3, mark);//nema smisla ali ja student3 mogu da dodam u student2
            Enrollment enroll9 = new Enrollment(exam6, student3, mark);
            Enrollment enroll10 = new Enrollment(exam6, student3, mark);
            Enrollment enroll11 = new Enrollment(exam6, student3, mark);

            Exams.Add(exam2);

        
            exam.Apply(student2);
            exam.Apply(student4);
            exam.Apply(student2);
            
            student2.ListOfExams.Add(enroll1);
            student2.ListOfExams.Add(enroll2);
            student2.ListOfExams.Add(enroll3);
            student2.ListOfExams.Add(enroll4);
            student2.ListOfExams.Add(enroll5);
            student2.ListOfExams.Add(enroll6);
            student3.ListOfExams.Add(enroll7);
            student3.ListOfExams.Add(enroll8);
            student3.ListOfExams.Add(enroll9);

            //Console.WriteLine("Prosecna ocena studenta je: "+student3.AverageMark2());
            //Console.WriteLine("Prosecna ocena studenta je: " + student2.AverageMark2());
            
            
          
            bool djokica = true;
            while (true)
            {
                Pokreni();
                int rezultat = int.Parse(Console.ReadLine());//kad radi parse isto pretvara u int, samo mozda ne po default u int32???
                switch (rezultat)
                {
                    case 1:
                        if (Students.Count != 0)
                            Console.WriteLine(student2.ToString());//ovo sam zakucao, nema smisla

                        else
                        {
                            Console.WriteLine("Nema studenata amigo");
                        }
                        break;
                    case 2:
                        student2.IsValid();
                        Students.Add(student4);
                        Console.WriteLine("Uspesno je dodat: \n" + student4.ToString());
                        break;
                    case 3:

                        Console.WriteLine("Unesi br indexa studenta kog hocete da obrisete");
                        string indexNumber = Console.ReadLine();
                        ObrisiStudenta(indexNumber);
                        Console.WriteLine("Student je uspesno obrisan!");
                        Console.ReadLine();
                        break;

                    case 4:
                        student2.IspisiIspite();
                        Console.WriteLine("Ukupan broj polozenih ispita studenta je: " + student2.GetPassedExamsEnum());
                        Console.WriteLine("Prosecan broj ocene studenta je : " + student2.AverageMark2());
                        break;
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
