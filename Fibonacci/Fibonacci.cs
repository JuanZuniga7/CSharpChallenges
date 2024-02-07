namespace CSharpChallenges.Fibonacci;

/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */

/*
 * Write a program that prints the first 50 numbers of the sequence
 * Fibonacci starting at 0.
 * - The Fibonacci series is made up of a succession of numbers in
 * the next one is always the sum of the two previous ones.
 * 0, 1, 1, 2, 3, 5, 8, 13...
 */

public class Fibonacci
{
    private static int MakeFibonacci(int limit)
    {
        if (limit <= 1)
        {
            return limit;
        }

        return MakeFibonacci(limit - 1) + MakeFibonacci(limit - 2);
    }

    public static void ShowFibonacci(int limit)
    {
        for (var i = 1; i <= limit+1; i++)
        {
            for (var j = 1; j <= limit + 1 - i; j++)
            {
                Console.Write(" ");
            }
            for (var k = 1; k <= i; k++)
            {
                Console.Write(MakeFibonacci(k) + " ");
            }
            if(i <= limit) Console.WriteLine();
        }
    }
}