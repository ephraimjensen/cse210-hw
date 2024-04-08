class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("50 West Viking Street", "Rexvurg", "Idaho", "USA");
        Address address2 = new Address("South 2nd West & 3rd West", "Rexburg", "Idaho", "USA");
        Address address3 = new Address("387 South 4th East", "Rexburg", "Idaho", "USA");

        Lecture lecture = new Lecture("Weekly Devotional", "Hear inspiring messages from church leaders and faculty.", "Tuesday, April 23rd, 2024", "11:30 AM", address1, "Alvin F. Meredith", 15000);
        Outdoor outdoor = new Outdoor("Ward Capture the Flag", "Play capture the flag with the ward.", "Monday, April 29th, 2024", "7:00 PM", address2, "Overcast");
        Reception reception = new Reception("Moroni and Natalie's Reception", "Come say HI at Moroni and Natalie's Wedding Reception.", "Saturday, May 18th, 2024", "4:00 PM", address3, "MoroniAndNatalie@gmail.com");

        events.Add(lecture);
        events.Add(outdoor);
        events.Add(reception);


        // int counter = 0;
        // foreach (Event e in events)
        // {
        //     counter++;
        Console.WriteLine($"Event 1: Lecture");
        Console.WriteLine($"The Standard Details are:\n{lecture.ReturnStandardDetails()}");
        Console.WriteLine($"The Full Details are:\n{lecture.ReturnFullDetails()}");
        Console.WriteLine($"The Short Description is:\n{lecture.ReturnShortDescription()}");

        Console.WriteLine($"\n\nEvent 2: Outdoor");
        Console.WriteLine($"The Standard Details are:\n{outdoor.ReturnStandardDetails()}");
        Console.WriteLine($"The Full Details are:\n{outdoor.ReturnFullDetails()}");
        Console.WriteLine($"The Short Description is:\n{outdoor.ReturnShortDescription()}");

        Console.WriteLine($"\n\nEvent 3: Reception");
        Console.WriteLine($"The Standard Details are:\n{reception.ReturnStandardDetails()}");
        Console.WriteLine($"The Full Details are:\n{reception.ReturnFullDetails()}");
        Console.WriteLine($"The Short Description is:\n{reception.ReturnShortDescription()}");

        //     }
    }
}