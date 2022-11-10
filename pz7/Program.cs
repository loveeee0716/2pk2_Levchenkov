using System;
class HelloWorld {
    static void Main()
    {
        int[] arr = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            arr[i] = rnd.Next(0, 50);
        }

        int[] arr_1 = new int[] { arr[0], arr[1], arr[2], arr[3], arr[4] };
        int[] arr_2 = new int[] { arr[5], arr[6], arr[7], arr[8], arr[9] };
        
        Array.Sort(arr_1);
        Array.Sort(arr_2);

        foreach (int a in arr_1)
        {
            Console.Write(a + "\t");
        }
        foreach (int a in arr_2.Reverse())
        {
            Console.Write(a + "\t");
        }
    }
}