namespace _7.seats_availabality
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
            bool[] seats = new bool[10];
           
            InitializeSeats(seats);
            DisplaySeatingArrangement(seats);
            Console.Write("Enter the seat number to book (1-10): ");
            int seatNumber = int.Parse(Console.ReadLine())-1;
            Console.WriteLine();
            BookSeat(seats, seatNumber);

            DisplaySeatingArrangement(seats);

        }
        void InitializeSeats(bool[] seats)
        {
            Random random = new Random();
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = random.Next(2) == 0;
            }
        }
        void DisplaySeatingArrangement(bool[] seats)
        {
            string status;
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i])
                {
                    status = "Available";
                }
                else
                {
                    status = "Booked";
                }
                Console.WriteLine($"Seat {i + 1}: {status}");
            }
        }
        void BookSeat(bool[] seats, int seatNumber)
        {
            if (seats[seatNumber])
            {
                seats[seatNumber] = false;
                Console.WriteLine($"Seat {seatNumber+1} has been successfully booked");
            }
            else { 
                Console.WriteLine($"Seat {seatNumber+1} is not available choose another seat");
            }
        }
    }
}
