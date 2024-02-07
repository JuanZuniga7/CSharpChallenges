namespace CSharpChallenges.PrimeNumbers;

/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

public static class Primes
{
    private static bool IsAPrimeNumbers(uint number)
    {
        if (number <= 1) return false;
        var dividers = 0;
        for (var i = 1; i <= number; i++)
        {
            if (number % i == 0) dividers++;
        }
        return dividers == 2;
    }

    public static void ShowPrimesInRange(uint limit)
    {
        for (uint i = 1; i < limit; i++)
        {
            Console.Write(IsAPrimeNumbers(i) ? i+" ": "");
        }
    }
}