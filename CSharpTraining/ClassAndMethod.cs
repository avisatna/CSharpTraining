using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class ClassAndMethod
    {
        public void VoidMethod()
        {
            
        }

        public string GetFullName(string FirstName, string SecondName)
        {
            //string fullName= FirstName+ SecondName;

            string fullName = string.Concat(FirstName, SecondName);

            return fullName;
        }


        public int GetSumofNumbers(int i, int j)
        {
            int sum = i + j;
            return sum;
        }

        public bool IsFiveCharWord(string word)
        {
            if (word.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
