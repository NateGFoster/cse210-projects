using System;
class Program
{
    static void Main()
    {
        //Console.WriteLine(" What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 101);
        int guess = -1;

        
        while (response != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());
        

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            }

            else
            {
                Console.WriteLine("That is correct!");
            }
    }
}

