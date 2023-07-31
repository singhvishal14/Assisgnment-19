using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment_19
{
    //public delegate int ArithmaticOperation(int n1, int n2);
    delegate T Operation<T>(T a, T b);
    internal class Program
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Multi(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int divide(int n1, int n2)
        {
            return n1 / n2;
        }
        static void Main(string[] args)
        {
            try
            {
                int n1, n2;
                //ArithmaticOperation Addition = Add;
                //ArithmaticOperation Subtraction = Sub;
                //ArithmaticOperation Multiplication = Multi;
                //ArithmaticOperation Division = divide;
                Operation<int> Addition = Add;
                Operation<int> Subtraction = Sub;
                Operation<int> Multiplication = Multi;
                Operation<int> Division = divide;
                Console.WriteLine("Enter No");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter No");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPress keys to Perform the Operation to\n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\n");
                
                again:
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            int result = Add(n1, n2);
                            Console.WriteLine($"\nThe Sum of {n1} and {n2} is {result}");
                            break;
                        }
                    case 2:
                        {
                            int result = Sub(n1, n2);
                            Console.WriteLine($"\nThe Substraction of {n1} and {n2} is {result}");
                            break;
                        }
                    case 3:
                        {
                            int result = Multi(n1, n2);
                            Console.WriteLine($"\nThe Multiplication of {n1} and {n2} is {result}");
                            break;
                        }
                    case 4:
                        {
                            int result = divide(n1, n2);
                            Console.WriteLine($"\nThe Division of {n1} and {n2} is {result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nWrong Option....!!!!\nSelect the Right Option");
                            goto again;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
           
        }
    }
}
