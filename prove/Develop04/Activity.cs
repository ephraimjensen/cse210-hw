

public class Activity
{
    int ShowPrompt()
    {
        return 1;
    }

    void EndingMessage()
    {

    }

    protected string activityName;
    protected string activityDescription;
    protected int time;
    public Activity(string activityName, string activityDescription, int time)
    {
        this.activityName = activityName;
        this.activityDescription = activityDescription;
        this.time = time;

    }

    public int DisplayActivityDescription()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName} Activity.\n");
        Console.WriteLine(activityDescription);
        Console.WriteLine("\nHow long, in seconds, would you like for your session to be? ");
        string response = Console.ReadLine();
        Console.Clear();

        return int.Parse(response);
    }

    public void AnimateCountdown(int startNumber)
    {
        while (startNumber > 0)
        {
            Console.Write(startNumber);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            startNumber -= 1;
        }


    }

    public void TimeSetter(int alfalfa)
    {
        this.time = alfalfa;
    }
    public void AnimateSpinner(int cycles)
    {
        int counter = 0;
        while (counter < cycles)
        {
            Console.Write("|");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(125);
            Console.Write("\b \b");
            counter += 1;

        }

    }
    public void DisplayFinishingMessage()
    {
        Console.WriteLine("Well done!!");
        AnimateSpinner(6);

        Console.WriteLine($"You have completed another {time} seconds of the {activityName} Activity.");
        AnimateSpinner(8);

    }
}