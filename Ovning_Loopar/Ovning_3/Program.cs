using System;

namespace Ovning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (true)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("Sen då?");
                }
                string response = Console.ReadLine().ToLower();
                if (response == "q")
                    return;

                x += x;
            }
        }
    }
}
