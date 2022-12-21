namespace pz13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumbers(new double[] { 1.2, 3.4, 5.6 }, 2));
        }

        static int GetNumbers(double[] nums, int n)
        {
            int count = 0;

            foreach (double d in nums)
            {
                if (d > n)
                {
                    count++;
                }
            }

            return count;
        }
    }
}