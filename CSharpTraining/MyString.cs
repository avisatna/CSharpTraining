using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class MyString
    {
        string strTxt = "  This is my string class with String example  ";

        public MyString()
        {
            Console.WriteLine("String Length: " + strTxt.Length);
            Console.WriteLine("Lower case string: " + strTxt.ToLower());
            Console.WriteLine("Upper case string: " + strTxt.ToUpper());

            Console.WriteLine("Trimmed string: " + strTxt.Trim());

            string[] strArray = strTxt.Split(" ");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            string strFruits = "Apple,Mango,Banana,Grapes,Pears,Papaya";
            Console.WriteLine("strFruits: " + strFruits);

            var result = strFruits.Contains("Mango");
            string strReplaced = strFruits.Replace("Banana", "Orange");
            Console.WriteLine("strFruits: " + strReplaced);

            string[] fruitsArray = strFruits.Split(',');
            for (int i = 0; i < fruitsArray.Length; i++)
            {
                Console.WriteLine(fruitsArray[i]);
            }
        }
    }
}
