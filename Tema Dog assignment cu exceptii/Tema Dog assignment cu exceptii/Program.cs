using System;

namespace Tema_Dog_assignment_cu_exceptii
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Max = new Dog();
            
            try
            {
                Max.Age = -8;

            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Max.Name = "P";

            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
