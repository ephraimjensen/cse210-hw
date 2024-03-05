using System.Runtime.InteropServices;

public class Breathing : Activity
{
    public Breathing(string activityName, int time, string activityDescription) : base(activityName, activityDescription, time)
    {
        this.activityName = activityName;
        this.time = time;
        this.activityDescription = activityDescription;

    }

    public void Breathe()
    {
        //preparation for the activity
        Console.Clear();
        Console.WriteLine("Get ready...\n");

        AnimateSpinner(6);

        int remainder = time % 10;
        int cycles = time / 10;
        int doTheRest = remainder / 2;
        if (remainder != 0)
        {
            Console.Write("Breathe in... ");
            AnimateCountdown(doTheRest);
            Console.WriteLine();
            Console.WriteLine();
            //pause for a few seconds (5)
            Console.Write("Breathe out... ");
            AnimateCountdown(doTheRest);
            Console.WriteLine();
            Console.WriteLine();
            //pause for a few seconds (5)
        }

        while (cycles > 0)
        {
            Console.Write("Breathe in... ");
            AnimateCountdown(5);
            Console.WriteLine();
            Console.WriteLine();
            //pause for a few seconds (5)
            Console.Write("Breathe out... ");
            AnimateCountdown(5);
            Console.WriteLine();
            Console.WriteLine();
            //pause for a few seconds (5)
            cycles -= 1;
        }




        DisplayFinishingMessage();

    }
}