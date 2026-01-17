namespace AlgorithmsLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the position of the Fibonacci number you want:");
            int position = int.Parse(Console.ReadLine()!);

            //int result = Fibonacci(position);
            //Console.WriteLine($"Fibonacci number at position {position} is: {result}");
            PrintFibonacciUpTo(position);
        }
        
        private static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static void PrintFibonacciUpTo(int position)
        {
            for (int i = 0; i <= position; i++)
            {
                Console.WriteLine($"Fibonacci number at position {i} is: {Fibonacci(i)}");
            }
        }
    }
}
