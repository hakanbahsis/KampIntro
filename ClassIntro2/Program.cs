using System;
using System.Reflection.Metadata;

namespace ClassIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.StudentId = 1001;
            student1.LastName = "Hakan";
            student1.FirstName = "Bahşiş";
            student1.Department = "Software Engineering";

            Student student2 = new Student();
            student2.StudentId = 1002;
            student2.FirstName = "Baran";
            student2.LastName = "Bahşiş";
            student2.Department = "Computer Engineering";

            Student[] students = new Student[] {student1, student2};
            foreach (var student in students)
            {
                Console.WriteLine("Öğrenci Numarası : "+student.StudentId+" "+
                                  "Öğrenci Adı : "+student.FirstName+" "+
                                  "Öğrenci Soyadı : "+student.LastName+" "+
                                  "Bölümü : "+student.Department);
            }

            Console.WriteLine("***********************************************************");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Öğrenci Numarası : " + students[i].StudentId + " " +
                                  "Öğrenci Adı : " + students[i].FirstName + " " +
                                  "Öğrenci Soyadı : " + students[i].LastName + " " +
                                  "Bölümü : " + students[i].Department);
            }

            Console.WriteLine("************************************************************");

            int a = 0;
            while (students.Length>a)
            {
                Console.WriteLine("Öğrenci Numarası : " + students[a].StudentId + " " +
                                  "Öğrenci Adı : " + students[a].FirstName + " " +
                                  "Öğrenci Soyadı : " + students[a].LastName + " " +
                                  "Bölümü : " + students[a].Department);
                a++;
            }

            Console.ReadLine();
        }
    }

    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}
