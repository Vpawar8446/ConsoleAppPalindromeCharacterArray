using System;

namespace ConsoleAppPalindromeCharacterArray
{
    class PalCharacter
    {


        internal void PalCharArray(char[] name)
        {
            bool palindrome = true;
            int i, j, num;
            num = name.Length;
            for (i = 0, j = num - 1; i < num / 2; i++, j--)
            {
                if (name[i] != name[j])
                {
                    palindrome = false;
                    break;
                }
            }
            Console.WriteLine("String : " + palindrome);
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            char[] name = new char[10];
            name = Console.ReadLine().ToCharArray();
            new PalCharacter().PalCharArray(name);
        }
    }
}
