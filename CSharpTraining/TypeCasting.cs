using System;

namespace CSharpTraining
{
    // Implicit Casting > (automatically) converting smaller type to larger type
    // char > int > long > double

    // Explicit Casting > converting larger type to smaller type
    // double > int > char
    internal class TypeCasting
    {
        public TypeCasting() 
        {

            int number = 5;

            double newNumber = number;

            char mychar = '1';
            string mystr = mychar.ToString();

            //explicit casting
            double myDouble = 7.27;
            int myint = Convert.ToInt32(myDouble);

        }

    }
}
