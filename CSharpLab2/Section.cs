using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    class Section
    {
        List<Student> studentsList = new List<Student>();
        public int SectionNumber { get; set; }
        public string SectionName { get; set; }

        public Section(int SectionNumber, string SectionName, List<Student> studentsList)
        {
            this.SectionNumber = SectionNumber;
            this.SectionName = SectionName;
            this.studentsList = studentsList;
        }

    }
}
