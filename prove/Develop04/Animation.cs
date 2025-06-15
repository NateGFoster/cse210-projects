
class Animation:Activity
{
    List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
    public void showSpinner(int seconds)
    // public void wait()
    {

        DateTime endTime = DateTime.Now.AddSeconds(5);
        for (int i = 0; i < 10; i++)
        {
            Console.Write("\b" + animationStrings[i]); // \b puts it back one
            Thread.Sleep(500);
            //i = (i+1)%animationStrings.Count;
        }

    }
    public void showCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
            Console.Write("\b\b"); // to be like the video you have to replace the number not write next to it
        }
    }
}