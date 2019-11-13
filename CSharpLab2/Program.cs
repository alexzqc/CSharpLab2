using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("A01185954", "Alex", "Chen");
            Student s2 = new Student("A01185955", "Lebron", "James");
            Student s3 = new Student("A01185956", "Stephen", "Curry");

            Student s4 = new Student("A01185957", "Kobe", "Bryant");
            Student s5 = new Student("A01185958", "Vince", "Carter");
            Student s6 = new Student("A01185959", "Shark", "O'Neal");

            Student s7 = new Student("A01185960", "Michael", "Jordan");
            Student s8 = new Student("A01185961", "Jason", "Kidd");
            Student s9 = new Student("A01185962", "Josh", "Smith");

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            List<Student> students1 = new List<Student>();
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);

            List<Student> students2 = new List<Student>();
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);

            Section section1 = new Section(1, "c#", students);
            Section section2 = new Section(2, "c++", students1);
            Section section3 = new Section(3, "Java", students2);

            Grade g1 = new Grade(s1, 20);
            Grade g2 = new Grade(s2, 17);
            Grade g3 = new Grade(s3, 19);

            Grade g4 = new Grade(s1, 19);
            Grade g5 = new Grade(s2, 17);
            Grade g6 = new Grade(s3, 20);

            Grade g7 = new Grade(s1, 5);
            Grade g8 = new Grade(s2, 3);
            Grade g9 = new Grade(s3, 19);

            List<Grade> gradesList1 = new List<Grade>();
            gradesList1.Add(g1);
            gradesList1.Add(g2);
            gradesList1.Add(g3);

            List<Grade> gradesList2 = new List<Grade>();
            gradesList2.Add(g4);
            gradesList2.Add(g5);
            gradesList2.Add(g6);

            List<Grade> gradesList3 = new List<Grade>();
            gradesList3.Add(g7);
            gradesList3.Add(g8);
            gradesList3.Add(g9);

            Assignment assignment1 = new Assignment("Create a folder", section1, 20, gradesList1);
            Assignment assignment2 = new Assignment("Create a repo", section2, 20, gradesList2);
            Assignment assignment3 = new Assignment("Create a website", section3, 20, gradesList3);

            Printer.PrintStudentNames(section1);
            Printer.PrintStudentNames(section2);
            Printer.PrintStudentNames(section3);

            Printer.PrintAssignmentGrades(assignment1);
            Printer.PrintAssignmentGrades(assignment2);
            Printer.PrintAssignmentGrades(assignment3);

            Printer.PrintAssignmentStudentGrade(assignment3, "A01185955");

            Console.ReadLine();
        }

    }
}
