using System;

class Program
{
    static void Main(string[] args)
    {
       
Console.WriteLine("Enter a list of numbers, type 0 when finished.");
List<int> theList = new List<int>(); //here is a list of integers
    theList.Add(5); // we can add the number 5
    theList.Add(10);
    theList.Add(15);

    int count = theList.Count();

    int sum = theList.Sum();

    foreach (int number in theList )

    }
}
//what class does a list belong to? ANS- the list class!
/*static void Main(string[] args)
{
    Console.WriteLine("Hello PRep1 WOrld!");

    List<int> theList = new List<int>(); //here is a list of integers
    theList.Add(5); // we can add the number 5
    theList.Add(10);
    theList.Add(15);

    int count = theList.Count();

    int sum = theList.Sum();

    foreach (int number in theList )
    {
        
    }
}