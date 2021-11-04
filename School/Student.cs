using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        public Student(string name, int age, int classN)
        {
            _name = name;
            _age = age;
            _classN = classN;
            _id = Guid.NewGuid();
        }
        public string _name;
        public int _age;
        public int _classN;
        public Teacher _teacher;
        public Guid _id;
    }
}
