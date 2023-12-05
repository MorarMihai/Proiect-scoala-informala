using System;

namespace tema_2_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfNumbers = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numbersOfNumbers];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int biggestNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (biggestNumber < array[i])
                {
                    biggestNumber = array[i];
                }
            }
            Console.WriteLine("Cel mai mare numar este " + biggestNumber);
            int smallestNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (smallestNumber > array[i])
                {
                    smallestNumber = array[i];
                }
            }
            Console.WriteLine("Cel mai mic numar este " + smallestNumber);
        }
    }
}
