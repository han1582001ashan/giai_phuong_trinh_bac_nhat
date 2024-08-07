using System;
namespace LinearEquationResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinearEquation Resolver");
            Console.WriteLine("Given a equation as 'a * x +b = 0', please enter constants");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("The solution is all x");
                }
                else
                {
                    Console.WriteLine("Not solution");
                }
            }
            else
            {
                double sol = -b / a;
                Console.WriteLine("The solution is :" + sol);
            }
        }
    }
}
