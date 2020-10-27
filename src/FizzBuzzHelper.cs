using System;

namespace teste_fizzbuzz
{
    public static class FizzBuzzHelper
    {
        public static bool EhMultiplicador(double dividendo, int divisor)
        {
            var retornoDivisao = dividendo % divisor == 0;
            return retornoDivisao;
        }

        public static string RetornaFizzBuzz(int numero)
        {
            if (EhMultiplicador(numero, 3) && EhMultiplicador(numero, 5))
            {
                return "FizzBuzz";
            }
            else
            {
                if (EhMultiplicador(numero, 3))
                {
                    return "Fizz";
                }
                else
                {
                    if (EhMultiplicador(numero, 5))
                    {
                        return "Buzz";
                    }
                }

            }

            return "";
        }
    }
}