using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstudentHM
{
    class Student : IStudent
    {
        public string FullName { get; set; }
        public int Course { get; set; }
        public string GroupNumber { get; set; }
        public string Faculty { get; set; }
        public int Stipend { get; set; }

        #region Конструкторы
        public Student() { }
        public Student(string fullName)
        {
            FullName = fullName;
        }
        public Student(string fullName, int course) : this(fullName)
        {
            Course = course;
        }
        public Student(string fullName, int course, string groupNumber) : this(fullName, course)
        {
            GroupNumber = groupNumber;
        }
        public Student(string fullName, int course, string groupNumber, string faculty) : this(fullName, course, groupNumber)
        {
            Faculty = faculty;
        }
        public Student(string fullName, int course, string groupNumber, string faculty, int stipend) : this(fullName, course, groupNumber, faculty)
        {
            Stipend = stipend;
        }
        #endregion

        #region Методы
        public void Show()
        {
            Console.WriteLine("Полное имя:\t" + FullName +
                "\nКурс:\t\t" + Course +
                "\nНомер группы:\t" + GroupNumber +
                "\nФакультет:\t" + Faculty +
                "\nСтипендия:\t" + Stipend);
        }
        public bool IsScholarship()
        {
            if (Stipend > 0) return true;
            return false;
        }
        public double AverageGrade(params int[] grades)
        {
            return grades.Average();
        }
        #endregion
    }
}
