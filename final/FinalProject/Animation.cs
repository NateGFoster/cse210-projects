
class Animation // I am just recycling this class from an old project to help make my behavior different for the intense heavy weight option and furthering my use of polymorphism
{
    List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
    public void showSpinner(int seconds)
    // public void wait()
    {

        DateTime endTime = DateTime.Now.AddSeconds(5);
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write("\b" + animationStrings[i % 4]); // \b puts it back one  divide by four takes teh remandier creatign a loop
            Thread.Sleep(500);
            Console.Write("\b");
            //i = (i+1)%animationStrings.Count;
        }

    }
    public void showCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "\b");
            Thread.Sleep(1000);
    
        }
    }
    
}