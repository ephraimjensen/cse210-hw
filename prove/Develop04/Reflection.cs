class Reflection : Activity
{
    private string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private string[] questions = { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    // Outputs 4

    public Reflection(string activityName, int time, string activityDescription) : base(activityName, activityDescription, time)
    {
        this.activityName = activityName;
        this.time = time;
        this.activityDescription = activityDescription;


    }



    public void Reflect()
    {
        // choose a random prompt
        Random rint = new Random();
        int promptNumber = rint.Next(1, prompts.Length) - 1;
        //display the randomly chosen prompt
        Console.WriteLine(prompts[promptNumber]);
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);


        DateTime currentTime = DateTime.Now;
        // check to see if time is up yet
        while (currentTime < endTime)
        {
            int questionNumber = rint.Next(1, questions.Length) - 1;
            Console.Write(questions[questionNumber]);
            Console.Write(" ");
            AnimateSpinner(7);
            Console.WriteLine();

            currentTime = DateTime.Now;


        }
        DisplayFinishingMessage();





    }
}