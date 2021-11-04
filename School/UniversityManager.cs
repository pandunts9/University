using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class UniversityManager
    {
        /// <summary>
        /// Attaching students to teachers in string array
        /// </summary>
        /// <param name="teachers">Given array from Teachers</param>
        /// <param name="students">Given array from Students</param>
        /// <returns>Returnes string array</returns>
        public string[] Attach(Teacher[] teachers, Student[] students)
        {
            string[] result = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length / teachers.Length; j++)
                {
                    if (i < students.Length)
                    {
                        students[i]._teacher = teachers[j];
                        result[i] = $"{students[i]._teacher._name}  -  {students[i]._name}";
                        i++;
                    }
                }
                i--;
            }
            return result;
        }
    }
}
