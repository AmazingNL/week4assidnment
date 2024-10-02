namespace _4.multiply_arrays
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
            Console.Write("Enter course name: ");
            Console.ReadLine();
            Console.Write("Enter number of students: ");
            int numbers = int.Parse(Console.ReadLine());
            string[] names = new string[numbers];
            int[] grades = new int[numbers];
            ReadNames(names);
            ReadGrades(grades, names); 
            Console.WriteLine($"Student John has the highest grade: {GetHighestGradeIndex(grades)}");
        }
        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name of student {i+1}: ");
                names[i] = Console.ReadLine();
                
            }

            Console.WriteLine();
        }
        void ReadGrades(int[] grades, string[] names) {
            
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade of {names[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }
        int GetHighestGradeIndex(int[] grades)
        {
            int index = grades[0];
            for(int i = 0; i < grades.Length; i++)
            { 
                if (grades[i] > index)
                {
                    index = grades[i];
                }
            }
            return index;
        }
    }
}
