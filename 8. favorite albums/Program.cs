namespace _8._favorite_albums
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
            string[] albums = new string[100];
            int numberOfAlbums = 2;

            DisplayAlbums(albums, numberOfAlbums);

            Console.Write("Enter the name of the book you want to search for: ");
            string searchAlbum = Console.ReadLine();

            if (FindAlbum(albums, numberOfAlbums, searchAlbum) == true)
            {
                Console.WriteLine($"The book {searchAlbum} is in your list!");
            }
            else {
                Console.WriteLine($"The book {searchAlbum} is not in your list!");
            }


        }
        void DisplayAlbums(string[] albums, int numberOfAlbums)
        {

            for (int i = 0; i < numberOfAlbums; i++)
            {
                Console.Write("Do you want to add another album? (yes/no) ");
                string input = Console.ReadLine().ToUpper();
                if (input == "NO")
                    break;
                else if (input != "YES")
                {
                    Console.WriteLine("Invalid");
                    break;
                }
                else
                {
                    Console.Write($"Enter the name of album {i + 1}: ");
                    albums[i] = Console.ReadLine();
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine($"{j + 1}. {albums[j]}");
                }
            }
            Console.WriteLine();
        }
        bool FindAlbum(string[] albums, int numberOfAlbums, string searchAlbum)
        {
            for(int i = 0;i < numberOfAlbums;i++) {
                if (albums[i] == searchAlbum)
                    return true;
            }
            return false;
        }
    }
}
