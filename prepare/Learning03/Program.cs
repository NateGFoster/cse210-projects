using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gimme a number");
        Console.ReadLine();
        Fraction fraction = new Fraction();

        Console.WriteLine("Gimme a number");
        string a = Console.ReadLine();
        int input = int.Parse(a);
        Fraction fraction_1 = new Fraction(input);

        Console.WriteLine("Gimme a number");
        string top = Console.ReadLine();
        int input_2 = int.Parse(top);
        string bottom = Console.ReadLine();
        int input_3 = int.Parse(bottom);
        Fraction fraction_2 = new Fraction(input_2, input_3);


        //fraction_1.GetFractrionString();
        Console.WriteLine(fraction_1.GetFractrionString());
        //fraction_2.GetDecimalValue();
        Console.WriteLine(  fraction_2.GetDecimalValue());
    }
   
}