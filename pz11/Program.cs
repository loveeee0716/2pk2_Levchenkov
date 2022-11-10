using System;
using System.Runtime.InteropServices;

class HelloWorld {
    static void Main()
    {
        string time = Console.ReadLine();
        string[] timesplit = time.Split('.');
        int hour = Convert.ToInt32(timesplit[0]);

        if (hour+5 <= 24)
        {
            Console.WriteLine((hour+5) + "." + timesplit[1] + "." + timesplit[2]);
        }
        else
        {
            Console.WriteLine(((hour+5)-24) + "." + timesplit[1] + "." + timesplit[2]);
        }
    }
}