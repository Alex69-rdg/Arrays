namespace Nai_chesto_srestan_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Въведи N: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Въведи число[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //zada4a
           
            byte maxCount = 0;
            int findedMostReperated = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int curentElement = numbers[i];
                byte count = 1;
                for (int k = i+1; k < numbers.Length; k++)
                {
                    if (curentElement == numbers[k])
                    {
                        count++;
                    }
                }
                if (maxCount < count)
                {
                    maxCount = count;// novo maxsimalno
                    findedMostReperated = curentElement;
                }
            }









            //output
            Console.WriteLine("------------------------");
            Console.WriteLine($"Elementat {findedMostReperated} se sresta {maxCount} puti");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

        }
    }
}
