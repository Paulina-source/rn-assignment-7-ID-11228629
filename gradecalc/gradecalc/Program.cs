using System;

class GradeCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a numerical grade (0-100) or type 'exit' to quit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
            {
                char letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The letter grade is: {letterGrade}\n");
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0 and 100 or type 'exit' to quit.\n");
            }
        }
    }

    static char GetLetterGrade(int grade)
    {
        if (grade >= 90)
            return 'A';
        else if (grade >= 80)
            return 'B';
        else if (grade >= 70)
            return 'C';
        else if (grade >= 60)
            return 'D';
        else
            return 'F';
    }
}
