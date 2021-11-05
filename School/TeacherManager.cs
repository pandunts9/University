using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class TeacherManager
    {
        public TeacherManager()
        {

        }
        /// <summary>
        /// Creates array of Teachers by the count you give
        /// </summary>
        /// <param name="count">Given Int32 value</param>
        /// <returns>Returnes array type of Teacher</returns>
        public Teacher[] Create(int count)
        {
            Random rnd = new Random();
            Teacher[] teachers = new Teacher[count];
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"Teacher{rnd.Next(1,20)}",rnd.Next(24,64));
            }
            return teachers;
        }
        /// <summary>
        /// Removes teacher by given id
        /// </summary>
        /// <param name="teachers">Given array type of Teacher</param>
        /// <param name="id">Given value Guid type</param>
        /// <returns>Returnes array type of Teachers</returns>
        public Teacher[] Remove(Teacher[] teachers, Guid id)
        {
            Teacher[] teachersRefr = new Teacher[teachers.Length - 1];
            for (int i = 0; i < teachersRefr.Length; i++)
            {
                if (teachers[i]._id != id)
                {
                    teachersRefr[i] = teachers[i];
                }
            }
            return teachersRefr;
        }
        /// <summary>
        /// Prints teacher list
        /// </summary>
        /// <param name="teachers"></param>
        public void Print(Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine($"{teachers[i]._name}  {teachers[i]._age} years ");
            }
        }
    }
}
