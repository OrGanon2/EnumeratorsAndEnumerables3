using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables3
{
    class Student
    {
        public int Grade { get; }
        public string Name { get; }

        public Student(int grade,string name)
        {
            Grade = grade;
            Name = name;
        }
    }
}
