using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "eererh";
            string str = "#12fg_3##";
            //string str = "chitra";
            bool result = CheckforUniqueCharacters(str);
            if(result)
                Console.WriteLine("String has all unique characters");
            else
                Console.WriteLine("String does not have all unique characters");
        }


        public static bool CheckforUniqueCharacters(string str)
        {
            bool[] strbool = new bool[128];
            if (str.Length > 128)
                return false;
            for (int i = 0; i < str.Length; i++)
            {
                int asciiValueofChar = str[i];
                if (strbool[asciiValueofChar]) //if its already true
                {
                    return false; //there is a duplicate value
                }
                strbool[asciiValueofChar] = true;//set boolean value representing that character to be true

            }
            return true; //all characters in the string are unique
        }
    }
}
