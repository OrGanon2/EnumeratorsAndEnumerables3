using System;
using System.Collections.Generic;

namespace EnumeratorsAndEnumerables3
{
    class Program
    {
        static void Main(string[] args)
        {
           

          //שאלה 1
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }
            // שאלה 2
            List<int> Nums = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            foreach (var num in Nums)
            {
                Console.WriteLine(num * 10);
            }
            //שאלה 3
            foreach (var item in new sdarot(10))
            {
                Console.WriteLine(item);
            }
            // שאלה 4
            Student Dor = new Student(100, "Dor");
            Student gal = new Student(80, "gal");
            Student david = new Student(60, "david");
            Student yaron = new Student(70, "yaron");
            StudentsWhoPracticeAlot StudentGrade = new StudentsWhoPracticeAlot();
            StudentGrade.AddStudent(Dor);
            StudentGrade.AddStudent(gal);
            StudentGrade.AddStudent(david);
            StudentGrade.AddStudent(yaron);
            foreach (Student student in StudentGrade)
            {
                Console.WriteLine(student.Name + " " + student.Grade);
            }
           



        }
    }
}
