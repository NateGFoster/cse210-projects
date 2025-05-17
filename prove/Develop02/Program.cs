using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal.");
        Picker picker = new Picker(); 
     

        Journal journal = new Journal(); //creates a journal object
       

        string response = "";
        while (response != "5")
        {
            Console.Write("1. Add Entry\n 2. Get Entry \n 3. Load Entry \n 4. Save Entry \n 5. Quit \n");
            response = Console.ReadLine();
            switch (response)
            {
                case "1":
    Entry entry = new Entry();
    entry.date = DateTime.Now.ToString("dd MMM HH:mm"); // Sets the date 

    Console.WriteLine("Would you like a random prompt or create your own?");
    Console.Write("Enter '1' for random, '2' to write your own: ");
    string promptChoice = Console.ReadLine();

    if (promptChoice == "1")
    {
        entry.question = picker.getRandom();
    }
    else if (promptChoice == "2")
    {
        Console.Write("Enter your custom prompt: ");
        entry.question = Console.ReadLine();

        // Optional: add prompt to picker
        picker.AddPrompt(entry.question);
    }
    else
    {
        Console.WriteLine("Invalid choice. Defaulting to random prompt.");
        entry.question = picker.getRandom();
    }
    Console.WriteLine($"\nPrompt: {entry.question}");
    Console.Write("Your answer: ");
    entry.answer = Console.ReadLine();

    journal.AddEntry(entry);
    Console.WriteLine("Entry added.");
    break;
                case "2": journal.DisplayEntries(); break; 
                case "3": Console.WriteLine("Where do you want to load from?");
                journal.LoadEntries(Console.ReadLine()); break;
                case "4": Console.WriteLine("Where do you want to save to?");
                journal.SaveEntries(Console.ReadLine()); break;
                case "5": break;
                
                             } 
        }
    }
}