public class Reflecting : Activity
{
   // private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    //private string _name = "Reflecting Activity";

    private Animation animation = new Animation();
    private List<string> _prompts = new List<string>
    {
        "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were less successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you use this experience to help you in the future?"
    };
    private List<string> _questions = new List<string>
        {
         "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when Gotham needed your help.",
        "Think of a time when you didn't do your best and someone was brutally murdered by the Joker and or Bane."
        };

    public Reflecting() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    
}

    // _reflectingMessage
    // _reflectionList
    public void RunReflectingActivity()
    {
        displayStartingMessage();
        animation.showSpinner(2);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            animation.showSpinner(2);
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)]; // AI had to help me on this specific line but now it makes sense.
            Console.WriteLine($"Consider the following prompt:\n ---{prompt}---");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            //string input = Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            if (DateTime.Now > endTime)
        {
                displayEndingMessage(_name, _description);
         animation.showSpinner(2);
            break;
        }

            // if (DateTime.Now >= endTime)
            // {
            //     break; // Exit the loop if time is up
            // }

            //if (input != " ")
            // {
            //      displayEndingMessage(_name, _description);

            // }
        }
        
    

    }
    
    

    // reflecting rand int ()

    // while !0
    // Display Reflecting()

    // Reflecting() 

}