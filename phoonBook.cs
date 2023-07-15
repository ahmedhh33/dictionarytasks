using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask
{
    internal class phoonBook
    {
        private static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        public static void AddContact()
        {
            Console.WriteLine("Add Contact");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("Contact already exists.");
            }
            else
            {
                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();
                phoneBook[name] = phoneNumber;
                Console.WriteLine("Contact added successfully.");
            }
        }
        public static void SearchContact()
        {
            Console.WriteLine("Search Contact");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (phoneBook.TryGetValue(name, out string phoneNumber))
            {
                Console.WriteLine($"Phone Number: {phoneNumber}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
        public static void DeleteContact()
        {
            Console.WriteLine("Delete Contact");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (phoneBook.Remove(name))
            {
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

    }

}
