using System;
class HelloWorld {
    static void Main()
    {
        char[][] arr = new char[5][]; 
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            int len = rnd.Next(6, 15);
            char[] sarr = new char[len];
            for(int j = 0; j < len; j++)
            {
                sarr[j] = Convert.ToChar(rnd.Next(97, 122)); // a = 97, z = 122
            }
            arr[i] = sarr;
        }

        Console.WriteLine("Задание 2");
        foreach (char[] row in arr)
        {
            foreach (char c in row)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        char[] last = new char[5];

        for (int i = 0; i < 5; i++)
        {
            last[i] = arr[i][arr[i].Length-1];
        }
        Console.WriteLine("Задание 3");
        foreach (char l in last)
        {
            Console.Write(l+" ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("Задание 4");
        foreach (char[] r in arr)
        {
            foreach (char c in r.Reverse())
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        Console.WriteLine("Задание 7");
        Console.WriteLine("Помогите...");
    }
}