using System;
using System.Net.Http.Headers;

namespace Remove_Character_From_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int retry = 1;
            while(retry == 1)
            {
                Console.WriteLine(Messages.Q001);
                string input = Convert.ToString(Console.ReadLine());
                int cont = 1;
                while(cont == Messages.NUM1.ToInt())
                {
                    Console.WriteLine(Messages.Q002);
                    string character = Convert.ToString(Console.ReadLine());
                    bool ifValid = ValidateCharacterLength(character);
                    if (ifValid)
                    {
                        Console.WriteLine(RemoveCharacterFromString(input, Convert.ToChar(character)));
                        cont = 0;
                    }
                    else
                    {
                        Console.WriteLine(Messages.ERR001);
                        cont = 1;
                    }

                    if(cont == Messages.NUM0.ToInt())
                    {
                        Console.WriteLine(Messages.Q003);
                        if(Convert.ToString(Console.ReadLine()) == Messages.NUM0)
                        {
                            retry = 0;
                        }
                    }
                }             
            }
        }

        public static string RemoveCharacterFromString(string input, char toRemove)
        {
            char[] charArr = input.ToCharArray();
            char[] newArr = new char[charArr.Length-1];
            int length = input.Length, newIndex = 0;
            for (int index = 0; index <= length - 1; index++)
            {
                if(charArr[index] != toRemove)
                {
                    newArr[newIndex] = charArr[index];
                    newIndex++;
                }
            }
            return new string(newArr);
        }

        public static bool ValidateCharacterLength(string character)
        {
            if(character.Length > 1)
            {
                return false;
            }

            return true;
        }
    }
}
