namespace CSharpChallenges.FizzBuzz;

/*Escribe un programa que muestre por consola (con un print) los
 números de 1 a 100 (ambos incluidos y con un salto de línea entre
 cada impresión), sustituyendo los siguientes:
 - Múltiplos de 3 por la palabra "fizz".
 - Múltiplos de 5 por la palabra "buzz".
 - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".*/
/* Write a program that shows through the console (with a print) the
 numbers from 1 to 100 (both included and with a line break between
 each print), replacing the following:
 - Multiples of 3 for the word "fizz".
 - Multiples of 5 for the word "buzz".
 - Multiples of 3 and 5 at the same time for the word "fizzbuzz".*/

public static class FizzBuzz
{
    private static bool MultipleOf3(UInt16 number) => number % 3 == 0;

    private static bool MultipleOf5(UInt16 number) => number % 5 == 0;
    
    public static string ValidateNumber(UInt16 number)
    {
        if (number is < 1 or > 100 ) return "can't use this number";
        if (MultipleOf3(number) && MultipleOf5(number)) return "fizzbuzz";
        if (MultipleOf3(number)) return "fizz";
        return MultipleOf5(number) ? "buzz" : "is Not";
    }
}