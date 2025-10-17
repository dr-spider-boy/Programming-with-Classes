using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal myjournal = new Journal();
        bool running = true;



        while (running)
        {
            Console.Clear();
            Console.WriteLine("The Journal Menu");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. See entire journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("");
            Console.Write("Enter a number:");
            string userinput = Console.ReadLine();
            int option = int.Parse(userinput);
            PromptGenerator generator = new PromptGenerator();




            if (option == 1)
            {
                Console.Clear();
                Entry entry1 = new Entry();

                string randomprompt = generator.GetRandomPrompt();
                Console.WriteLine(randomprompt);
                string response = Console.ReadLine();
                entry1._entrytext = response;
                entry1._entrydate = DateTime.Now;
                entry1._entryprompt = randomprompt;
                myjournal._listofentries.Add(entry1);
            }

            else if (option == 2)
            {
                Console.Clear();
                myjournal.DisplayAllEntries();
                Console.ReadKey();
            }

            else if (option == 3)
            {
                Console.Clear();
                myjournal.SaveAllEntries();
                Console.ReadKey();
            }

            else if (option == 4)
            {
                Console.Clear();
                myjournal.LoadAllEntries();
                Console.ReadKey();
            }
            else if (option == 5)
            {
                running = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid option...");
                Console.ReadKey();
            }
        }
        Console.Clear();
        Console.WriteLine("Have a nice day!");
        Console.ReadKey();
        
        
        
        
        
        
        
        
        
  
    }
}