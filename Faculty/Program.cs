using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculty.Model;

namespace Faculty
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor profesor = new Professor();
            Course course = new Course();
            Exam exam = new Exam();
            Student student = new Student();
            Student student2 = new Student("333", "Vlado", "Pokrajac", DateTime.Parse("12/16/1991"));

            Console.WriteLine("1.Show all students\n2.Add new Student\n3.Delete Student\n4.GetPassedExamas\n5.Exit Program\nChoose from 1 to 5...");
            int rezultat=int.Parse(Console.ReadLine());

            if (rezultat == 1 && exam.ListOfStudents.Count != 0) //ovo ne mora, ali cisto da bih ukljucio proveru
            {
                student.ToString();

            }

            else if (rezultat == 1 && exam.ListOfStudents.Count == 0)
            {
                Console.WriteLine("Nema studenata amigo");
                Console.ReadLine();

            }
            else if (rezultat == 2)
            {
                
                student2.IsValid();
                exam.Apply(student2);
                Console.WriteLine(student2.ToString());
                Console.WriteLine("Student je uspesno dodat");
                Console.ReadLine();
               
            }

            else if (rezultat == 3)
            {
                Console.WriteLine("Unesi br indexa studenta kog hocete da obrisete");
                //Ne znam kako da namestim ovo, pukla mi koncentracija, a prosto je
                {

                }
            }
        }
    }
}
