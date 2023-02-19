namespace ArithmeticLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create lambda operators for arithmetic operations
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) => y == 0 ? throw new DivideByZeroException("Division by zero error.") : x / y;
            
            Console.Write("Enter the first number: ");
            var num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            var op = char.Parse(Console.ReadLine());
            
            double result;

            switch (op)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Sub(num1, num2);
                    break;
                case '*':
                    result = Mul(num1, num2);
                    break;
                case '/':
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}