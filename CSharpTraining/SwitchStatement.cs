using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class SwitchStatement
    {

        public void GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Mar");
                    break;
                case 4:
                    Console.WriteLine("Apr");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Jun");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }            
        }

        public void GetMonthNameByIfElse(int month)
        {
            if (month == 1)
            {
                Console.WriteLine("Jan");
            }
            if (month == 2)
            {
                Console.WriteLine("Feb");
            }
            if (month == 3)
            {
                Console.WriteLine("Mar");
            }
            if (month == 4)
            {
                Console.WriteLine("Apr");
            }
        }
    }


}
