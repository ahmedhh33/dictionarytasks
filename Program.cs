using System;

namespace DictionaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Dictionary<string, int> wordFrequency = CountWordFrequency(sentence);

            Console.WriteLine("Word Frequency:");
            foreach (KeyValuePair<string, int> entry in wordFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
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


    }
}