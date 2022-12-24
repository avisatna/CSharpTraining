using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    internal class MyExceptions
    {
        public void CreateStringArray()
        {
            string[] strArr = { "Microsoft", "Google", "Facebook", "Twitter" };

            try
            {
                Console.WriteLine(strArr[4]);
            }
            catch (Exception ex)
            {
                File.WriteAllText("C:\\GitLabTraining\\CSharpException.txt", ex.ToString());
                Console.WriteLine("Some issue in our Program, Please try after some time.");
            }

            Console.WriteLine(strArr[3]);
        }
    }
}
