using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace consolecalculatorapp
{
    public class Calculator
    {

        public int Add(int numberone,int numbertwo)
        {
            return numberone + numbertwo;
        }

        public int Subtract(int numberone,int numbertwo)
        {
            return numberone - numbertwo;
        }

        public int Multiple(int numberone,int numbertwo)
        {
            return numberone * numbertwo;
        }

        public double Divide(int numberone,int numbertwo)
        {
            if(numberone == 0 || numbertwo == 0)
            {
                throw new DivideByZeroException("Cant divide by zero");
            }

            double result = (double)numberone /numbertwo;
            return Math.Round(result,2);
        }

        public static int GetNumber(string message)
        {
            Console.WriteLine(message);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input, Try Again");
            }
            return number;
        }
    }
}
