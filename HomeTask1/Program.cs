using System;

namespace HomeTask1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 12; i += 2)
            {
                for (int j = 0; j < 12 - i - 1; j += 2)
                {
                    Console.Write("  ");
                }
                for (int k = 12 - i - 1; k < 12; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
