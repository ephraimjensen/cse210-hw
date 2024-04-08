using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();

        // create one activity of each type
        Running running = new Running("04 May 2024", 30f, 5.0f);
        Cycling cycling = new Cycling("08 Jun 2023", 45f, 11f);
        Swimming swimming = new Swimming("19 Oct 2022", 60f, 50f);
        // put these activities on the same list

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        //iterate throught the list and call Get Summary method on each item and display the results

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}