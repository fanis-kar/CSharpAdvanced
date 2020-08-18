using CSharpAdvanced.Topics;
using System;
using System.ComponentModel;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main()
        {
            int decision = 0;

            while(decision != 9)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("1. Dynamic Types");
                Console.WriteLine("2. Extension Methods");
                Console.WriteLine("9. Exit");
                Console.WriteLine("===============================================");
                Console.Write("Choose section (1-9): ");
                decision = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===============================================");
                Console.Clear();

                switch (decision)
                {
                    case 1:
                        DynamicType dt = new DynamicType();
                        dt.Basic();

                        break;
                    case 2:
                        ExtensionMethods em = new ExtensionMethods();
                        em.Basic();

                        break;
                    case 9:
                        break;
                    default:
                        //throw new InvalidEnumArgumentException("Sorry, invalid selection");
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
