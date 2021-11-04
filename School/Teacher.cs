using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Teacher
    {
        public Teacher(string name, int age)
        {
            _name = name;
            _age = age;
            _id = Guid.NewGuid();
        }
        public string _name;
        public int _age;
        public Student[] _students;
        public Guid _id;
    }
}
