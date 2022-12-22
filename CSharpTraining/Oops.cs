using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    // OOP: Object Oriented Programming
    // Polymorphism: Method Overloading & Method Overriding
    // Abstraction
    // Inheritance
    // Ecapsulation
    public class Oops : MyAbstructClass
    {
        private static string variable1 = "";
        public string variable2 = "";

        public string str = variable1;

        public void Method1()
        {
            Console.WriteLine("This Method1");
        }

        public string Method1(string s)
        {
           return "This is Method1";
        }

        public void Method1(int number2)
        {
            Console.WriteLine("This Method1");
        }

        public void Method1(string s, int number1)
        {
            Console.WriteLine("This Method1");
        }

        public virtual void MethodToChange()
        {
            Console.WriteLine("Hello This is Avinash");
        }

        // Abstruct Method
        public override void AbsMethod1()
        {
            Console.WriteLine("This is Abstruct Method1");
        }
    }

    public class MyClass : Oops
    {
        public override void MethodToChange()
        {
            //base.MethodToChange();
            Console.WriteLine("This, This is Yash");            
        }
    }


    public class NewClass : MyCalculator
    {
        void MyCalculator.Add()
        {
            throw new NotImplementedException();
        }

        void MyCalculator.Divide()
        {
            throw new NotImplementedException();
        }

        void MyCalculator.Multiply()
        {
            throw new NotImplementedException();
        }

        void MyCalculator.Substract()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class MyAbstructClass
    { 
        public abstract void AbsMethod1();

        public void NonAbsMethod()
        {
            Math.Sqrt(8);
            Console.WriteLine("This is non Abstruct method");
        }
    }

    public interface MyCalculator
    {
        void Add();
        void Substract();
        void Multiply();
        void Divide();        
    }
}
