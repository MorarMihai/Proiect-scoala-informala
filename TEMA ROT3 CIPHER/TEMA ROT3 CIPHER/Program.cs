using System;
using System.Text;
//using System.Text;

namespace TEMA_ROT3_CIPHER
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder cipher = new StringBuilder(Console.ReadLine());
            StringBuilder alphabet = new StringBuilder ("abcdefghijklmnopqrstuvwxyz");
            StringBuilder newCipher = new StringBuilder("");
            for(int i = 0; i < cipher.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (cipher[i] == alphabet[j])
                    {
                        if(cipher[i] == 'x')
                        {
                            newCipher = newCipher.Append(alphabet[i]);
                            break;
                        }
                        if(cipher[i] == 'y')
                        {
                            newCipher = newCipher.Append(alphabet[1]);
                            break;
                        }
                        if(cipher[i] == 'z')
                        {
                            newCipher = newCipher.Append(alphabet[1 + 1]);
                            break;
                        }
                        newCipher = newCipher.Append(alphabet[j + 3]);
                        break;
                    }
                }             
            }
            Console.WriteLine(newCipher);
        }
    }
}
