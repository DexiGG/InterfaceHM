using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstudentHM
{
    interface IStudent
    {
        string FullName { get; set; }
        int Course { get; set; }
        string GroupNumber { get; set; }
        string Faculty { get; set; }
        int Stipend { get; set; }

        void Show();
        bool IsScholarship();
        double AverageGrade(params int[] grades);
    }
}
