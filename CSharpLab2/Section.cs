using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    class Section
    {
       public List<Student> students = new List<Student>();
        public int SectionNumber { get; set; }
        public string SectionName { get; set; }

        public Section(int SectionNumber, string SectionName, List<Student> students)
        {
            this.SectionNumber = SectionNumber;
            this.SectionName = SectionName;
            this.students = students;
        }

    }
}
