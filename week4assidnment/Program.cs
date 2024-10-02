namespace week4assidnment
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
            int[] numbers = new int[ Element ];
            FillArray( numbers );
            DisplayArray( numbers );

        }
        void FillArray(int[] numbers) { 
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = random.Next(1, 100);
            }
        }
        void DisplayArray(int[] numbers) { 
            for (int i = 0; i < numbers.Length; i++) { 
                Console.WriteLine($"Element {i+1} is: {numbers[i]}" );
            }
        }
    }
}
