using System;
using System.Collections.Generic;

class Student
{
    // Поля класу
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double AverageGrade { get; set; }

    // Конструктор класу
    public Student(string firstName, string lastName, int age, double averageGrade)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        AverageGrade = averageGrade;
    }

    // Метод для виведення інформації про студента
    public void PrintInfo()
    {
        Console.WriteLine($"Ім'я: {FirstName}, Прізвище: {LastName}, Вік: {Age}, Середній бал: {AverageGrade}");
    }

    // Метод перевірки, чи є студент відмінником
    public bool IsExcellent()
    {
        return AverageGrade >= 90;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення списку студентів
        List<Student> students = new List<Student>
        {
            new Student("Максим", "Луценко", 17, 95),
            new Student("Микита", "Іваненко", 17, 75),
            new Student("Микита", "Кейс", 17, 85),
            new Student("Анатолій", "Кулак", 17, 80)
        };

        // Виведення інформації про всіх студентів
        Console.WriteLine("Інформація про студентів:");
        foreach (var student in students)
        {
            student.PrintInfo();
        }

        // Виведення списку студентів-відмінників
        Console.WriteLine("\nСписок студентів-відмінників:");
        foreach (var student in students)
        {
            if (student.IsExcellent())
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - Середній бал: {student.AverageGrade}");
            }
        }
    }
}