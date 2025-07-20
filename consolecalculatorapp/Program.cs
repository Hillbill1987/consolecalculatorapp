namespace consolecalculatorapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator app = new Calculator();

            Console.WriteLine("Welcome to Console Calculator");
            Console.WriteLine("Please select an option\n1. Add\n2. Subtract\n3. Multiple\n4. Divide");
            var result = Console.ReadLine();
            int num1 = Calculator.GetNumber("Enter the first number");
            int num2 = Calculator.GetNumber("Enter the second number");
            switch (result)
            {
                case "1":
                    var AddedOutcome = app.Add(num1, num2);
                    Console.WriteLine("The answer is " + AddedOutcome);
                    break;
                case "2":
                    var SubtractOutcome = app.Subtract(num1, num2);
                    Console.WriteLine("The answer is " + SubtractOutcome);
                    break;
                case "3":
                    var MultiplyOutcome = app.Multiple(num1,num2);
                    Console.WriteLine("The answer is " + MultiplyOutcome);
                    break;
                case "4":
                    if(num2 == 0)
                    {
                        Console.WriteLine("Can not divide by zero");
                    }
                    else
                    {
                        var dividedOutcome = app.Divide(num1, num2);
                        Console.WriteLine("the answer is " + dividedOutcome);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
