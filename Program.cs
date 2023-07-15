using System;

namespace DictionaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1 split");
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Dictionary<string, int> wordFrequency = CountWordFrequency(sentence);

            Console.WriteLine("Word Frequency:");
            foreach (KeyValuePair<string, int> entry in wordFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine("Task2 hashset uniq");
            //Console.WriteLine("Enter 10 numbers:");
            //int[] numbers = new int[3];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //   // Console.WriteLine(numbers[i]);
            //}
            int[] numbers = { 1, 2, 3, 1, 56, 7, 2, 3 };

            HashSet<int> Uniq = GetUniqnumber(numbers);
            Console.Write("the uniqe words are: ");
            foreach(int i in Uniq)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            Console.WriteLine("Task3 phonebiik");

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Phone Book Program");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Search Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
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