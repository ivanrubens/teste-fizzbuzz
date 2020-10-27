using System;
using teste;

namespace teste_buzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var total = 100;

            for (var i = 1; i <= total; i++)
            {
                string stringFizzBuzz = FizzBuzzHelper.RetornaFizzBuzz(i);

                if (stringFizzBuzz != "")
                {
                    Console.WriteLine(stringFizzBuzz);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

    }
}
