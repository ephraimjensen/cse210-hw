class Listing : Activity
{
    private string[] prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private List<string> userResponses = new List<string>();
    public Listing(string activityName, string activityDescription, int time) : base(activityName, activityDescription, time)
    {
        this.activityName = activityName;
        this.time = time;
        this.activityDescription = activityDescription;


    }
    public void DisplayUserResponses()
    {
        foreach (var item in userResponses)
        {
            Console.WriteLine(item);
        }
    }

    public void Enumerate()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        //get and display a random prompt
        Random rint = new Random();
        int promptNumber = rint.Next(1, prompts.Length) - 1;
        Console.WriteLine(prompts[promptNumber]);
        Console.Write("You may being in:  ");
        AnimateCountdown(5);

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);


        DateTime currentTime = DateTime.Now;
        // check to see if time is up yet
        while (currentTime < endTime)
        {
            string fastResponse = Console.ReadLine();
            userResponses.Add(fastResponse);

            currentTime = DateTime.Now;


        }

        Console.WriteLine($"You listed {userResponses.ToArray().Length} items!\n");

        DisplayFinishingMessage();


    }

}