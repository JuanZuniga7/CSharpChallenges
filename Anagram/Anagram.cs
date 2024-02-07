namespace CSharpChallenges.Anagram;

/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

/*
 * Write a function that takes two words (String) and returns
 * true or false (Bool) depending on whether or not they are anagrams.
 * - An Anagram consists of forming a word by rearranging ALL of them
 * the letters of another initial word.
 * - It is NOT necessary to check that both words exist.
 * - Two exactly the same words are not an anagram.
 */

public class Anagram
{
    public static bool ValidateAnagram(string word1, string word2)
    {
        if (word1.Length < 2 || word2.Length < 2) return false;
        if (word1.Length != word2.Length) return false;
        var array1 = word1.ToCharArray();
        var array2 = word2.ToCharArray();
        Array.Sort(array1);
        Array.Sort(array2);
        return !array1.Where((t, i) => t != array2[i]).Any();
    }

}