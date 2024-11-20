using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "An", Age = 16 },
            new Student { Name = "Binh", Age = 18 },
            new Student { Name = "Anh", Age = 14 },
            new Student { Name = "Chi", Age = 19 },
            new Student { Name = "Minh", Age = 15 }
        };

        // a. 
        Console.WriteLine("Danh sach hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // b. 
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        var filteredStudents = students.Where(student => student.Age >= 15 && student.Age <= 18);
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // c. 
        Console.WriteLine("\nHoc sinh co ten bat đau bang chu 'A':");
        var studentsWithNameA = students.Where(student => student.Name.StartsWith("A"));
        foreach (var student in studentsWithNameA)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // d. 
        int totalAge = students.Sum(student => student.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. 
        var oldestStudent = students.OrderByDescending(student => student.Age).First();
        Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
        Console.WriteLine($"Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. 
        Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan:");
        var sortedStudents = students.OrderBy(student => student.Age);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}
