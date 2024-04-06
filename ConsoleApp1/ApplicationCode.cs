using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ApplicationCode
    {
        //***************** Convert String to lower case

        public void ConvertStringToLowercase()
        {
            string str = string.Empty;
            Console.WriteLine("Enter a number:");
            str = Console.ReadLine();
            Console.WriteLine(str.ToLower());
            Console.ReadLine();
        }

        //****************Reverse string******************
        public void ReverseStringpredefineFunction()
        {
            string str = "Ranjan";
            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            string rvStr = new string(strArray);
            Console.WriteLine($"Revese str with built in function : {rvStr}");
            Console.ReadLine();
        }

        //****************Reverse withoit predefined function******************
        public void ReverseStringWithoutpredefineFunction()
        {
            string str = "Ranjan";
            string reverse = "";

            int Length = str.Length - 1;
            var test = str[5];
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            //Displaying the reverse word  
            Console.WriteLine("Reverse word without reverse function is {0}", reverse);
            Console.ReadLine();
        }

        //****************Reverse withoit predefined function******************
        public void ReverseNumber()
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }

        //***********************Replace first 3 letter with #

        public void ReplaceHash()
        {

            int n = 2;
            string text = "ABCD";
            string replacement = "##";
            string result = replacement + text.Substring(n);

            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
