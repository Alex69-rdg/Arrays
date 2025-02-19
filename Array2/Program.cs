namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се въведат н на брой имена от клавиатурате
            // Да се въведе низ търсено име
            //Ако е в масива да се отпечати индекса му
            // Ако го няма в масива да се отпечата "не е намерено"


            Console.Write("Kolko imena ste vuvedesh? ");
            int n=int.Parse(Console.ReadLine());

            string[] names=new string[n];
            for (int i=0; i<=names.Length-1; i++)
            {
                Console.Write($"name [{i}] = ");
                names[i] = Console.ReadLine();
            }



            Console.WriteLine("vuvedi turseno ime: ");
            string searchName=Console.ReadLine();
            bool isFound= false;
            byte count = 0;
            for (int i=0; i< names.Length; i++)
            {
                if (searchName==names[i])
                {
                    Console.WriteLine($"{searchName} e na {i} pozicia");
                    isFound = true;
                    count++;
                   
                    
                }
            }
            if (isFound == false)
            {
               Console.WriteLine($"{searchName} NOT FOUND!");
            }
            else
            {
               Console.WriteLine($"{searchName} se sreshta {count} puti");
            }
             

            // otput
            Console.WriteLine("---------------------------");
            for (int i = 0; i <= names.Length-1; i++)//===> index
            {
                Console.WriteLine($"numbers[{i}] = {names[i]}");
            }
        }
    }
}
