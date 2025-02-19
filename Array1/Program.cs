namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[8];

            //1.Input
            for (int i =0;i<numbers.Length;i++)
            {
                Console.Write($"numbers[{i}] = ");
                numbers[i] = int.Parse( Console.ReadLine() );
            }
            // 3 ontabnotkas
            long sum = 0;
            long sumEven = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];

                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
                
               
            }
            Console.WriteLine($"Sum= {sum}");
            Console.Write($"Avg = {(double)sum /numbers.Length}");

            //2. Output= Print all element
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}
