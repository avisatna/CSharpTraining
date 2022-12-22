using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class LoopClass
    {
        // Less Than:  i < j
        // Less than or equal to: i <= j
        // Geater than: i> j
        // Geater than or equal to: i >= j
        // Equal to: i == j
        // Not Equal to: i =! j
        // or: ||
        // And: &&

        public void IfLoopMethod()
        {
            int i = 7;
            int j = 7;
            if (i == j && i <= j)
            {

            }
        }

        public void WhileLoopMethod2()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("5*" + i + ":" + 5 * i);
                i++;
            }
        }

        public void DoWhileLoopMethod2()
        {
            int i = 1;
            do
            {
                Console.WriteLine("5*" + i + ":" + 5 * i);
                i++;
            } while (i <= 0);
        }
    }
}