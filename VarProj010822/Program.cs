using System;

namespace VarProj010822
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            var equation = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
            var equation1 = Math.Abs(x) * Math.Sin(x);
            var eq2 = 2 * Math.PI * x;
            var eq3 = Math.Max(x, y);

            Console.WriteLine(equation);
            Console.WriteLine(equation1);
            Console.WriteLine(eq2);
            Console.WriteLine(eq3);
        }
    }
}
//checked
