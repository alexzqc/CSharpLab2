using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab2
{
    class Printer
    {
        public static void PrintStudentNames(Section section)
        {
            foreach (Student student in section.students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);

            }
        }
    
    public static void PrintAssignmentGrades(Assignment assignment)
        {
            foreach (Grade grade in assignment.gradesList)
            {
                Console.WriteLine(grade.StudentTotal);

            }
        } 
        public static void PrintAssignmentStudentGrade(Assignment assignment, string studentId)
        {
            string a = studentId;
            foreach (Grade grade in assignment.gradesList)
            {
                if(grade.student.StudentId == a)
                Console.WriteLine(grade.StudentTotal);
            }
        }
    }
}
