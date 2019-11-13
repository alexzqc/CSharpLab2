using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    class Grade
    {
        public int StudentTotal { get; set; }
        public Student student { get; set; }

        public Grade(Student student, int StudentTotal)
        {
            this.student = student;
            this.StudentTotal = StudentTotal;
        }
    }
}
