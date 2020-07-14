using System;
using System.Reflection.Metadata.Ecma335;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // DONE - Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference                         

        // DONE - Create an Add method that passes 3 integers
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // DONE - Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend    
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        // DONE - Create a Multiply method that passes 2 integers
        public int Mutiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string GetHello()
        {
            return "Hello!";
        }

        public string SayGoodbye()
        {
            return "Goodbye!";
        }
    }
}
