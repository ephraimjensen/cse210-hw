using System;
using System.ComponentModel;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program


{

    static void Main(string[] args)
    {
        var menu = new Menu();
        bool dontStop = true;


        while (dontStop)
        {
            Console.Clear();
            dontStop = menu.RunMenu();
        }

    }
}



