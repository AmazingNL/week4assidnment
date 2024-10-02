using System.Linq.Expressions;

namespace _2.get_smallest_value_in_integer_array
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
            const int Element = 20;
            int[] numbers = new int[Element];
            FillArray(numbers);
            DisplayArray(numbers);
            Console.WriteLine($"Smallest number is: {GetSmallestNumber(numbers)}");
        }
        void FillArray(int[] numbers)

        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
        }
        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]:00} ");
            }
        }
        int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 0; i < numbers.Length; i++) {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i] ;
                }     
            }
            Console.WriteLine();
            return smallest;
        }
    }
}
