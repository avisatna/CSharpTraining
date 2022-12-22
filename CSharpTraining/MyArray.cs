using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class MyArray
    {
        string[] strArray = { "Hello", "Apple", "Tomato" };

        int[] intArray = { 23, 45, 565, 67, 12 };

        // Sized Array
        string[] newstrArray = new string[4];

        // Constructor
        public MyArray()
        {

        }

        public void ArrayMethod()
        {
            Console.WriteLine(strArray[0]);

            Console.WriteLine(strArray[1]);

            Console.WriteLine(strArray[2]);

            Console.WriteLine(intArray[0]);

            Console.WriteLine(intArray[1]);

            Console.WriteLine(intArray[2]);

            // Update value in existing array
            strArray[0] = "Banana";

            Console.WriteLine(strArray[0]);

            // get the length of Array
            Console.WriteLine(strArray.Length);

            // get the length of Array
            Console.WriteLine(intArray.Length);
        }

        public void NewArrayMethod()
        {
            newstrArray[0] = "iPhone";
            newstrArray[1] = "OnePlus";
            newstrArray[2] = "Motorola";
            newstrArray[3] = "Google";
            

            // i=1 length=4 4<4
            for (int i = 0; i < newstrArray.Length; i++)
            {
                Console.WriteLine(newstrArray[i]);
            }

            Array.Sort(newstrArray);
            Array.Reverse(newstrArray);            

            foreach (var item in newstrArray)
            {
                Console.WriteLine(item);
            }
        }


        public void MultiDimentionalArray()
        {
            int[,] intArray = { { 2,4,6}, { 5,7,7}, { 89, 67, 7} };

            //Console.WriteLine(intArray[2,2]);

            // Updating value in 2D array
            intArray[2, 2] = 10;

           // Console.WriteLine(intArray[2, 2]);


            // Printing array values using loop
            //foreach (var item in intArray)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i,j]+ " ");
                }
                Console.WriteLine();
            }

        }
    }
}
