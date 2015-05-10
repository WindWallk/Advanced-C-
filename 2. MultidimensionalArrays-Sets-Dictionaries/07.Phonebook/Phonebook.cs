using System;
using System.Collections.Generic;

namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string contact = Console.ReadLine();
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

            while (contact != "search")
            {
                string[] contactInfo = contact.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                string name = contactInfo[0];
                string number = contactInfo[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = new List<string>();
                }

                phonebook[name].Add(number);

                contact = Console.ReadLine();
            }

            string search = Console.ReadLine();
            while (!String.IsNullOrEmpty((search)))
            {
                if (phonebook.ContainsKey(search))
                {
                    Console.WriteLine("{0} -> {1}", search, string.Join(", ", phonebook[search]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", search);
                }

                search = Console.ReadLine();
            }
        }
    }
}