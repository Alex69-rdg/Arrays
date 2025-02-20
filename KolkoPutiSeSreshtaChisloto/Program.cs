namespace KolkoPutiSeSreshtaChisloto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Въведи число: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Въведи число[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Zadacha
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int count = 0;
                for (int j =0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                
                //Output
                Console.WriteLine($"Числото {numbers[i]} се среща {count} пъти");
            }


            //Console.WriteLine("--------------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
               
            //}


        }
    }
}
