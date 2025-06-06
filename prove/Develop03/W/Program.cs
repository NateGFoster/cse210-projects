using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello welcome to the scripture memorizer");
        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
        string UserInput = "";

        Scripture PickedScripture = new Scripture();
        while (UserInput != "quit")
        {
          
            Console.Clear();
            Console.WriteLine(PickedScripture.GetDisplayText());

            if (PickedScripture.AllHiddenWords())
            {
                // Console.WriteLine("Good Job!");
                break;
            }
            
           
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            UserInput = Console.ReadLine();


            if (UserInput == "quit")
            {
                break;
            }
            PickedScripture.HideRandWords(3);
            
            // {PickedScripture.HideRandWords(3);}
             
        }

        Console.WriteLine("Good Job!");
        
         
        //     private string _book;
        // private string _chapter;

        // private int _startVerse;

        // private int _endVerse;



        // _book = book

        // reference ref1 = new Reference("1 Nephi", "3" , 7);
        // Scripture scripture1 = new Scripture();
        // scripture1.scripture();
        // Reference ref2 = new Reference("1 Nephi", "5", 7, 10);

    }
}