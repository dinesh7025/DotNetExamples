namespace LeapYearPgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a Leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
            }
        }
    }
}
