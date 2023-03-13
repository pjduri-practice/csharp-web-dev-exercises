using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Classes;

public class Student
{
    private static int nextId = 1;
    public string Name { get; set; }
    public int StudentId { get; set; }
    public int NumberOfCredits { get; set; }
    public double Gpa { get; set; }

    public Student (string name, int studentId, int numberOfCredits, double gpa)
    {
        Name = name;
        StudentId = studentId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    public  Student (string name, int studentId) : this(name, studentId, 0, 0.0) 
    {}

    public Student(string name): this(name, nextId)
    {
        nextId++;
    } 

    public string listStudentInfo()
    {
        return $"Name: {Name}\n" +
            $"Student ID: {StudentId}\n" +
            $"Credits: {NumberOfCredits}\n" +
            $"GPA: {Gpa}";
    }

}
