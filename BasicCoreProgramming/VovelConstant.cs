using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class VovelConstant
    {
        public void CheckVovelConstant()
        {
            Console.Write("Enter an alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            if (char.IsLetter(ch))
            {
                if (IsVowel(ch))
                    Console.WriteLine($"{ch} is a vowel.");
                else
                    Console.WriteLine($"{ch} is a consonant.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an alphabet.");
            }
        }

        static bool IsVowel(char ch)
        {
            ch = char.ToLower(ch);
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
        }
    }
    }

