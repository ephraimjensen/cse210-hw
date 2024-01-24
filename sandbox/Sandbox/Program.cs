using System;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // // Console.WriteLine("Hello Sandbox World!");
        // // int x;
        // // x = 5;
        // // // Console.WriteLine(x);
        // // int y = 4;
        // // // Console.WriteLine(x * y);
        // // // Console.WriteLine("Hello world");
        // // // Console.Write("There will not be a new line after this.");

        // // // Console.WriteLine(" This adds a new line to offset the previous one.");
        // // // Console.Write("What is your favorite color? ");
        // // // string color = Console.ReadLine();
        // // // Console.WriteLine($"Your favorite color is {color}! ");
        // // if (x > y)
        // // {
        // //     Console.WriteLine(" x is greater than y");

        // // }
        // // int number = 5;
        // // number = number + 3;
        // // if (number > 3)
        // // {
        // //     Console.WriteLine("Greater");
        // // }
        // int x = 6;
        // int y = 7;
        // int z = 4;

        // if (x > y)
        // {
        //     Console.WriteLine("greater than y");
        // }

        // else if (x > z)
        // {
        //     Console.WriteLine("greater than z");
        // }

        // else
        // {
        //     Console.WriteLine("less than both y and z");
        // }
        // string valueInText = "42";
        // int number = int.Parse(valueInText);

        // var makes = new List<string>();
        // var model = new List<string>();
        // var year = new List<string>();
        // var mpg = new List<string>();

        var car = new Car();

        car._model = "Civic";
        car._make = "Honda";
        car._milesPerGallon = 30;
        car._tankSize = 5;

        var person = new Person();
        person.name = "sue";
        person.phone = "333-3333";

        car.owner = person;

        var person1 = new Person();
        person1.name = "joe";
        person1.phone = "444-4444";


        var car2 = new Car();
        car2._model = "myModel";
        car2._make = "myMake";
        car2._milesPerGallon = 5;
        car2._tankSize = 30;

        car2.owner = person1;



        // Car car1 = new Car();
        // car1._model = "Civic";
        // car1._make = "Honda";
        // car1._milesPerGallon = 30;
        // car1._tankSize = 5;

        // cars.Add(car1);

        car.Display();
        car2.Display();
        // car1.Display();


    }
}

