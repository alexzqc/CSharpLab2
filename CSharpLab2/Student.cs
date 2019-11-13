using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string StudentId, string FirstName, string LastName)
        {
            this.StudentId = StudentId;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
