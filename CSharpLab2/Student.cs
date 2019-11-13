using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(int StudentId, string FirstName, string LastName)
        {
            this.StudentId = StudentId;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
