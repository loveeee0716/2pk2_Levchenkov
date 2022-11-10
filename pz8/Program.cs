using System;
class HelloWorld {
    static void Main()
    {
        int[,] arr = new int[10,10];
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                arr[i, j] = rnd.Next(10, 99);
                Console.Write(arr[i,j]+"\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 10; i++)
        {
            int sum = 0;
            for (int j = 0; j < 10; j++)
            {
                sum += arr[j,i];
            }
            Console.WriteLine("Сумма " + (i+1) + " столбца: " + sum);
        }
    }
}