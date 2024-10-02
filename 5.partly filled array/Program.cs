using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5.partly_filled_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            const int number = 5;
            int[] numbers = new int[number];
            ReadNumbers(numbers);
            Console.WriteLine();
            Console.Write("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of occurrences of search value ({searchValue}) is: {CountSearchValue(numbers, searchValue)}");

        }
        void ReadNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("Enter a number(0 = stop): ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] == 0) break;
            }
            Console.WriteLine();
        }
        int CountSearchValue(int[] numbers, int searchValue)
        {
            int value = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] == searchValue)
                {
                    value++;
                }
            }
            return value;
        }
    }
}
