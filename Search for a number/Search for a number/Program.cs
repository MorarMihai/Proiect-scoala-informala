using System;

namespace Search_for_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "Volvo", "Audi", "Mercedes", "Mazda", "Ford", "Toyota" };
            string input = Console.ReadLine();
            bool answer = false;
            for(int i = 0; i < cars.Length; i++)
            {
                if(input == cars[i])
                {
                    answer = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (answer == false)
            {
                Console.WriteLine("The car doesn't exist");
            }
            
        }
    }
}
