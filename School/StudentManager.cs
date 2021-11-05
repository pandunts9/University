using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class StudentManager
    {
        public StudentManager()
        {
        }
        /// <summary>
        /// Creates array of  students by the count you give
        /// </summary>
        /// <param name="count">Given Int32 value</param>
        /// <returns>Returnes array  type of Students</returns>
        public Student[] Create(int count)
        {
            Random rnd = new Random();
            Student[] students = new Student[count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"Student{rnd.Next(1,400)}", rnd.Next(7, 19), rnd.Next(1, 13));
            }
            return students;
        }
        /// <summary>
        /// Distributes students in clases by ages 
        /// </summary>
        /// <param name="students">Given Student value</param>
        /// <returns>array type of Student </returns>
        public Student[] Distribute(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                switch (students[i]._age)
                {
                    case 7:
                        students[i]._classN = 1;
                        break;
                    case 8:
                        students[i]._classN = 2;
                        break;
                    case 9:
                        students[i]._classN = 3;
                        break;
                    case 10:
                        students[i]._classN = 4;
                        break;
                    case 11:
                        students[i]._classN = 5;
                        break;
                    case 12:
                        students[i]._classN = 6;
                        break;
                    case 13:
                        students[i]._classN = 7;
                        break;
                    case 14:
                        students[i]._classN = 8;
                        break;
                    case 15:
                        students[i]._classN = 9;
                        break;
                    case 16:
                        students[i]._classN = 10;
                        break;
                    case 17:
                        students[i]._classN = 11;
                        break;
                    case 18:
                        students[i]._classN = 12;
                        break;
                    default:
                        students[i]._classN = default;
                        break;

                }
            }
            return students;
        }
        /// <summary>
        /// Removes student by given id
        /// </summary>
        /// <param name="students">Given array type of Students</param>
        /// <param name="id">Given value Guid type</param>
        /// <returns>Returnes array type of Students</returns>
        public Student[] Remove(Student[] students,Guid id)
        {
            Student[] studentsRefr = new Student[students.Length-1];
            for (int i = 0; i < studentsRefr.Length; i++)
            {
                if(students[i]._id != id)
                {
                    studentsRefr[i] = students[i];
                }
            }
            return studentsRefr;
        }
        /// <summary>
        /// Prints Students list
        /// </summary>
        public void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i]._name}  class-{students[i]._classN}  {students[i]._age} years ");
            }
        }
    }
}
