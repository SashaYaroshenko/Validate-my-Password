using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class validPass
    {
        public static string validator(string password)
        {
            string result = "";
            int count_Digit = 0;
            int count_Letter = 0;
            if (password.Length>=3 && password.Length<=20)
            {
                for(int i = 0; i < password.Length; i++)
                {
                    if(Char.IsLetter(password[i]))
                    {
                       count_Letter++;
                    }
                    else if(Char.IsDigit(password[i]))
                    {
                        count_Digit++;
                    }
                    else
                    {
                        result = "INVALID";
                    }
                }
                if(count_Digit!=0 && count_Letter!=0 && result!="INVALID")
                {
                    result = "VALID";
                }
                else
                {
                    result = "INVALID";
                }
            }
            else
            {
                result = "INVALID";
            }
            return result;
        }
    }
}
