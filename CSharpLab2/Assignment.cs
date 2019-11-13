using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    class Assignment
    {

        public string AssignmentName { get; set; }
        public Section section { get; set; }
        public int total { get; set; }
        public List<Grade> gradesList = new List<Grade>();

        public Assignment(string AssignmentName, Section section, int total, List<Grade> gradesList)
        {
            this.AssignmentName = AssignmentName;
            this.section = section;
            this.total = total;
            this.gradesList = gradesList;
        }

    }
}
