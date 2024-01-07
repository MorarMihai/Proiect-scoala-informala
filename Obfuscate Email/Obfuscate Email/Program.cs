using System;
using System.Text;

namespace Obfuscate_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder email = new StringBuilder(Console.ReadLine());
            int indexOfAt = -1;
            for(int i = 0; i <email.Length; i++)
            {
                if(email[i] == '@')
                {
                    indexOfAt = i;
                }
            }
            //Console.WriteLine(indexOfAt);
            for(int i = 0; i < email.Length; i++)
            {
                if(indexOfAt > i )
                {
                    email[i] = '*';
                }
            }
            Console.WriteLine(email);
        }
    }
}
