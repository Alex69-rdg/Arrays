

namespace FindEvenElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input count elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0;i< nums.Length; i++)
            {
                Console.Write($"numbers[{i}] = ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            //Zadacha
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && i%2==0)
                {
                    Console.WriteLine($"{nums[i]} -> {i} pozicia");
                }
            }
        }
    }
}
