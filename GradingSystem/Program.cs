namespace GradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Grading System------");
            Console.WriteLine("Enter the marks: ");
            int marks = int.Parse(Console.ReadLine());
            if (marks >= 90)
                Console.WriteLine("Your grade is 'A'");
            else if (marks >= 80)
                Console.WriteLine("Your grade is 'B'");
            else if (marks >= 70)
                Console.WriteLine("Your grade is 'C'");
            else if (marks >= 60)
                Console.WriteLine("Your grade is 'D'");
            else
                Console.WriteLine("Your grade is 'F'");
         
        }
    }
}
