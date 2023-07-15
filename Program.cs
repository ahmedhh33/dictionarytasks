using System;

namespace DictionaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isProgramRunning = true;

            while (isProgramRunning)
            {
                Console.WriteLine("Task list");
                Console.WriteLine("1. Word Frequency Counter");
                Console.WriteLine("2. Unique Elements");
                Console.WriteLine("3. Phone Book");
                Console.WriteLine("4. Student Grade Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice1;
                if (int.TryParse(Console.ReadLine(), out choice1))
                {
                    switch (choice1)
                    {
                        case 1:
                            {
                                Console.WriteLine("***********Task1 split****************");
                                Console.WriteLine("Enter a sentence:");
                                string sentence = Console.ReadLine();

                                Dictionary<string, int> wordFrequency = CountWordFrequency(sentence);

                                Console.WriteLine("Word Frequency:");
                                foreach (KeyValuePair<string, int> entry in wordFrequency)
                                {
                                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                                }
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("*****************Task2 hashset uniq***********");
                                int[] numbers = { 1, 2, 3, 1, 56, 7, 2, 3 };

                                HashSet<int> Uniq = GetUniqnumber(numbers);
                                Console.Write("the uniqe words are: ");
                                foreach (int i in Uniq)
                                {
                                    Console.Write(i);
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("&&&&&&&&&&&&&&&Task3 phonebiik&&&&&&&&&&&&&");

                                bool isRunning = true;

                                while (isRunning)
                                {
                                    Console.WriteLine("Phone Book Program");
                                    Console.WriteLine("1. Add Contact");
                                    Console.WriteLine("2. Search Contact");
                                    Console.WriteLine("3. Delete Contact");
                                    Console.WriteLine("4. Exit");
                                    Console.Write("Enter your choice: ");

                                    int choice2;
                                    if (int.TryParse(Console.ReadLine(), out choice2))
                                    {
                                        switch (choice2)
                                        {
                                            case 1:
                                                phoonBook.AddContact();
                                                break;
                                            case 2:
                                                phoonBook.SearchContact();
                                                break;
                                            case 3:
                                                phoonBook.DeleteContact();
                                                break;
                                            case 4:
                                                isRunning = false;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid choice. Please try again.");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                    }

                                    Console.WriteLine();
                                }
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("&&&&&&&&&&&&&&&Task4 students grade &&&&&&&&&&&&&");

                                bool isOn = true;

                                while (isOn)
                                {
                                    Console.WriteLine("Grade Tracker Program");
                                    Console.WriteLine("1. Add Grades for Student");
                                    Console.WriteLine("2. Calculate Average Grade for Student");
                                    Console.WriteLine("3. Display Average Grades for All Students");
                                    Console.WriteLine("4. Exit");
                                    Console.Write("Enter your choice: ");

                                    int choice3;
                                    if (int.TryParse(Console.ReadLine(), out choice3))
                                    {
                                        switch (choice3)
                                        {
                                            case 1:
                                                StudentGradeBook.AddGradesForStudent();
                                                break;
                                            case 2:
                                                StudentGradeBook.CalculateAverageGradeForStudent();
                                                break;
                                            case 3:
                                                break;
                                                StudentGradeBook.DisplayAverageGradesForAllStudents();
                                                break;
                                            case 4:
                                                isOn = false;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid choice. Please try again.");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter a number.");
                                    }

                                    Console.WriteLine();
                                }
                            }
                            break;
                        case 5:
                            isProgramRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }

            }
        }
        static Dictionary<string, int> CountWordFrequency(string sentence)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            char[] breakchar = new char[] { ' ', '.', ',' };
            string[] nwords = sentence.Split(breakchar, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0;i<nwords.Length; i++)
            {
                wordFrequency.Add(nwords[i],i);
            }

            return wordFrequency;
        }

        public static HashSet<int> GetUniqnumber(int[] num)
        {
            HashSet<int> Uniqe = new HashSet<int>(num);
            return Uniqe;
        }


    }
}