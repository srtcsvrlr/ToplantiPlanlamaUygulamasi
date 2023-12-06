namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (IsPrimeNumber(6))
            {
                    
            }
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}