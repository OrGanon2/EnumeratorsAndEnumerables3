using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables3
{
    
    class StudentsWhoPracticeAlot: IEnumerable
    {
        List<Student> StudentList = new List<Student>();
        public void AddStudent(Student studentTypes)
        {
            StudentList.Add(studentTypes);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].Grade >= 10)
                {
                     yield return StudentList[i];
                }
            }
        }
    }
}
