namespace BasicMathTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath calculator = new BasicMath();
            Console.WriteLine("Please enter the first number: ");
            double num1, num2, result;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter the number correctly! ");
            }
            Console.WriteLine("Please enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter the number correctly! ");
            }
            result = calculator.Add(num1, num2); // Call instance method on 'calculator'
            Console.WriteLine("The final result is: " + result);
        }
    }
}
