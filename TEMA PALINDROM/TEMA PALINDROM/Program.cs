using System;

namespace TEMA_PALINDROM
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "";
            string secondWord = "";
            firstWord = Console.ReadLine();
            for (int i = firstWord.Length - 1; i >= 0; i--)
            {
                secondWord += firstWord[i];
            }
            if (secondWord == firstWord)
            {
                Console.WriteLine("Stringul este palindrom \n Stringul introdus a fost {0} si inversului lui este {1}", firstWord, secondWord);
            }
            else
            {
                Console.WriteLine("Stringul nu este palindrom \n Stringul introdus a fost {0} si inversului lui este {1} {1}", firstWord, secondWord);
            }
        }
    }
}
