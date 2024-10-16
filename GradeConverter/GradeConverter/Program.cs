namespace GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grade converter app");
            String continueChoice;
           
            do {
                Console.Write("Please enter your grade as an integer: ");
                int score = int.Parse(Console.ReadLine());
                String grade;

                if(score < 60)
                {
                    grade = "F";
                }
                else if (score <= 67)
                {
                    grade = "D";
                }
                else if (score <= 79)
                {
                    grade = "C";
                }
                else if (score <= 87)
                {
                    grade = "B";
                }
               else
                {
                    grade = "A";
                }

                Console.WriteLine($"Your letter grade is: {grade}");
                Console.Write("Would you like to go again? (y/n): ");
                continueChoice = Console.ReadLine();  
            } while (continueChoice == "y");

            Console.WriteLine("Goodbye");
        }
    }
}
