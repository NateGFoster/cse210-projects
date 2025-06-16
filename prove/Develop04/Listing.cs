public class Listing : Activity
{
    //private string _listingMessage;
    private string _listingList;

    //private string _description = ("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    //private string _name = "Listing Activity";
    private Animation animation = new Animation();
    //public void Listing()
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
{

}
    public void RunListingActivity()
    {
        displayStartingMessage();
        animation.showSpinner(4);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //while (DateTime.Now < endTime)

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine("Get Ready...");
        animation.showCountDown(5);
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");

        List<string> userList = new List<string>(); // this is the list that stores the answers
        Console.ReadLine();

        do // another do while loop which i am starting to like a lot they're really useful
        {
            Console.Write("> ");
            _listingList = Console.ReadLine();

            if (_listingList != "")
            {
                userList.Add(_listingList);
            }
        } while (DateTime.Now < endTime);
        //         while (Console.In.Peek()!= -1) // i needed to clear the input buffer because it was getting clogged AI helped with this problem
        //         {
        //             Console.In.Read();
        // }

    } 
 }

    // listRandInt()
    
    // displayList()
    
    // count = 0;
    // if
     //Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")