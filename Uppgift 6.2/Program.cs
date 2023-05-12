using System;
namespace program
{
    class program
    {
        static int Störst(int tal1, int tal2)
        {
            if(tal1 < tal2)
            {
                return tal2;
            }
            else if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två heltal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Här ser vi att ");
            if (tal1 != tal2)
            {
                int tal3 = Störst(tal1, tal2);
                Console.WriteLine(tal3 + " är störst");
            }
            else
            {
                Console.WriteLine("talen har samma värde.");
            }
        }
    }
}