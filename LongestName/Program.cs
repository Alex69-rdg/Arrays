namespace LongestName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko imena? ");
            byte n= byte.Parse(Console.ReadLine());

            string[] names=new string[n];
            string longName = "";
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Vuvedi ime [{i}] = ");
                names[i] = Console.ReadLine();
            }
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names.Length > longName.Length)
            //    {
            //        longName = names;
            //    }
            //}
            
            
             names[0] = "Alex";
            names[n-1] = "Tonq Belezireva";
            // sreden element
            int avgIndex = names.Length / 2;
            names[avgIndex] = "Georgi Genov";
            //simetri4ni
            for(int i=0; i <= avgIndex; i++)
            {
                if (names[i] != names[(names.Length - 1) - i])
                {

                }
            }
            


            Console.WriteLine("---------------------------");
            for (int i = names.Length-1;i >= 0;i--)
            {
                Console.WriteLine($"{names[i]}, " );
            }

            //Console.WriteLine(longName);

        }
    }
}
