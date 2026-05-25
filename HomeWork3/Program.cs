using System;

class Task1
{
    public static void RunTask1()
    {
        #region task 1
        var number = Convert.ToInt32(Console.ReadLine());

        if (number % 5 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("NO");
        }
        #endregion
    }

}

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 2

            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());

            var max = Math.Max(x, y);
            var min = Math.Min(x, y);

            double sum = x + y;
            Console.WriteLine(sum);

            var difference = max - min;
            Console.WriteLine(difference);

            var product = x * y;
            Console.WriteLine(product);

            if (min == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                var quotient = max / min;
                Console.WriteLine(quotient);
            }

            #endregion
        }
    }
}

class Task3
{
    public static void RunTask3()
    {
        #region task 3
        var x = Convert.ToInt32(Console.ReadLine());
        var y = Convert.ToInt32(Console.ReadLine());

        var temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"x ={x} ; y = {y};");
        #endregion
    }
}

class Task4
{
    public static void RunTask4()
    {
        #region task 4
        var number = Convert.ToInt32(Console.ReadLine());

        for (var i = 1; i <= 9; i++)
        {
            var result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
        #endregion
    }
}

class Task5
{
    public static void RunTask5()
    {
        #region task 5
        var n = Convert.ToInt32(Console.ReadLine());

        for (var i = 1; i < n; i++)
        {
            if (i % 2 == 0)
            {
                var square = i * i;
                Console.WriteLine(square);
            }
        }
        #endregion
    }
}
