// using System.IO.Compression;
















class Program
{
    static void Main(string[] args)
    {



        Assignment alfalfa = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(alfalfa.GetSummary());
        Console.WriteLine(alfalfa.GetSummary());

        MathAssignment barley = new MathAssignment("Roberto Rodriguez", "fractions", "7.3", "8-19");
        Console.WriteLine(barley.GetSummary());
        Console.WriteLine(barley.GetHomeworkList());

        WritingAssignment corn = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(corn.GetSummary());
        Console.WriteLine(corn.GetWritingAssignment());


        //         Console.WriteLine("Hello Learning04 World!");

        //         Student s1 = new Student("id1", "Bob", "CSE");
        //         Faculty f2 = new Faculty("id2", "Sue", "BioAg");

        //         List<Person> people = new List<Person>();
        //         people.Add(s1);
        //         people.Add(f2);

        //         foreach (Person person in people)
        //         {
        //             Console.WriteLine(person.ReturnInfo());
        //             if (person is Student)

        //             {
        //                 var student = (Student)person;
        //                 Console.WriteLine(student.Display());
        //             }
        //             else if (person is Faculty)
        //             {
        //                 var faculty = (Faculty)person;
        //                 Console.WriteLine(faculty.Display());
        //             }
        //         }

    }
}

// class Person
// {
//     private string id;
//     private string name;

//     protected Person(string id, string name)
//     {
//         this.id = id;
//         this.name = name;
//     }
//     public string ReturnInfo()
//     {
//         return $"{name}: {id}";
//     }
// }

// class Student : Person
// {
//     private string major;

//     public Student(string id, string name, string major) : base(id, name)
//     {
//         this.major = major;

//     }
//     public string Display()
//     {
//         return $"{ReturnInfo()} - {major}";
//     }




// }

// class Faculty : Person
// {
//     private string department;

//     public Faculty(string id, string name, string department) : base(id, name)
//     {
//         this.department = department;
//     }
//     public string Display()
//     {
//         return $"{ReturnInfo()} - {department}";
//     }
// }