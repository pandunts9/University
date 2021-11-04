using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager stManager = new StudentManager();
            Student[] students = stManager.Create(10);
            stManager.Distribute(students);
            stManager.Print(students);
            Console.WriteLine();
            TeacherManager tManager = new TeacherManager();
            Teacher[] teachers = tManager.Create(3);
            tManager.Print(teachers);
            Console.WriteLine();
            UniversityManager univManager = new UniversityManager();
            string[] attachement = univManager.Attach(teachers, students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(attachement[i]);
            }
            

        }
            
    }
}
