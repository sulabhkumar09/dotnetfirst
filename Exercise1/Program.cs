using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Enter 1 for integer , Enter 2 for float , Enter 3 for boolean ");
                String n = Console.ReadLine();
                int v = int.Parse(n);
                Console.WriteLine("enter input");
                switch (v)
                {
                    case 1:
                        {
                            String str = Console.ReadLine();
                            int a = int.Parse(str);
                            Console.WriteLine("using int.parse " + a);
                            int b = Convert.ToInt32(str);
                            Console.WriteLine("using convert.ToInt " + b);
                            int x;
                            int.TryParse(str, out x);
                            Console.WriteLine("using int.TryParse " + x);
                            break;

                        }
                    case 2:
                        {
                            String str = Console.ReadLine();
                            float a = float.Parse(str);
                            Console.WriteLine("using float.parse  " + a);
                            float x;
                            float.TryParse(str, out x);
                            Console.WriteLine("using float.TryParse " + x);
                            break;
                        }
                    case 3:
                        {
                            String str = Console.ReadLine();
                            bool x;
                            bool.TryParse(str, out x);
                            Console.WriteLine("using bool.TryParse " + x);

                            break;

                        }
                    default:
                        {
                            Console.WriteLine("invalid input");
                            break;
                        }
                }
                Console.WriteLine("press 1 for exit or press any other integer to continue");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 1);
            Console.ReadKey();

        
        }
    }
}
