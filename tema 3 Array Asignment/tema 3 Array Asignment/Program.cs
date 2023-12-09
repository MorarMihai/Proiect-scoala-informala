using System;

namespace tema_3_Array_Asignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Mihai", "Alin", "Marian", "Alexandru", "Ion" };
            string biggestName = names[0];
            for(int i = 0;i < names.Length;i++)
            {
                if(biggestName.Length < names[i].Length)
                {
                    biggestName = names[i];
                }
            }
            Console.WriteLine("Cel mai lung nume este" + ": " + biggestName);
            string smallestName = names[0];
            for(int i = 0; i < names.Length; i++)
            {
                if(smallestName.Length > names[i].Length)
                {
                    smallestName = names[i];
                }
            }
            Console.WriteLine("Cel mai scurt nume este" +": " + smallestName);
        }
    }
}
