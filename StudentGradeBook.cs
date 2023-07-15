using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask
{
    public class StudentGradeBook
    {
        private static Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();


        public static void AddGradesForStudent()
        {
            Console.WriteLine("Add Grades for Student");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter grades (separated by spaces):");
            string gradesInput = Console.ReadLine();

            List<int> grades = gradesInput.Split(' ')
                                          .Select(int.Parse)
                                          .ToList();

            if (studentGrades.ContainsKey(name))
            {
                studentGrades[name].AddRange(grades);
            }
            else
            {
                studentGrades[name] = grades;
            }

            Console.WriteLine("Grades added successfully.");
        }


        public static void CalculateAverageGradeForStudent()
        {
            Console.WriteLine("Calculate Average Grade for Student");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            if (studentGrades.ContainsKey(name))
            {
                List<int> grades = studentGrades[name];
                double averageGrade = grades.Average();
                Console.WriteLine($"Average grade for {name}: {averageGrade}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }


        public static void DisplayAverageGradesForAllStudents()
        {
            Console.WriteLine("Display Average Grades for All Students");

            foreach (KeyValuePair<string, List<int>> entry in studentGrades)
            {
                string name = entry.Key;
                List<int> grades = entry.Value;
                double averageGrade = grades.Average();
                Console.WriteLine($"Average grade for {name}: {averageGrade}");
            }
        }
    }

}
