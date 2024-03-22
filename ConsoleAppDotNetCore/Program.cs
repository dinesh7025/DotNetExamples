namespace ConsoleAppDotNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            Console.WriteLine("This is Kakarot");*/
            #region Datatypes
            /*int productId = 1;
            string produtName = "Dell Precision";
            decimal productPrice = 2500000m;
            float rating = 4.5f;
            Console.WriteLine($"Id: {productId}\nName: {produtName}\nPrice: {productPrice}\nRatings:{rating}");*/
            #endregion
            #region User Input
            //UserInput
            /* Console.WriteLine("Enter the UserID:");
             int userId =int.Parse( Console.ReadLine() );
             Console.WriteLine("Enter the UserName:");
             string userName = Console.ReadLine();
             Console.WriteLine($"UserID: {userId}\nUserName: {userName}");*/
            #endregion
            #region Nullable values
            /*//--? datatype can accept nullable values
            // default will provide values eg. 0-int, empty-string, false-bool
            int? username = default;
            string? password = default;
            username = null;
            Console.WriteLine(username);
            Console.WriteLine(password);
            // Assign nullable values to non-nullable datatype using coalesce(??)
            int rollNo = username ?? 0; */
            #endregion
            #region Dynamic Variables
            /*dynamic variable1;
            variable1 = 100;
            variable1 = "Kakarot";
            //To find the dataType name
            Console.WriteLine(variable1.GetType());*/
            #endregion
            #region dateTime
            /* //Date and Time DataType
             DateTime currDate = DateTime.Now;
             Console.WriteLine(currDate);
             DateTime dateaTime1 = new DateTime();//DEFAULT VALUES
             Console.WriteLine(dateaTime1);
             DateTime dateaTime2 = new DateTime(2024,03,12);
             Console.WriteLine(dateaTime2);*/
            #endregion
            #region Enumerations
           /* //Enum are named constants
            //Readbility, Maintability, type Safety
            Console.WriteLine(ticketStatus.Available);
            int status = (int)ticketStatus.Available;
            Console.WriteLine(status);*/

            #endregion




        }
        //enum ticketStatus
        //{
        //    Available,
        //    Booked
        //}
    }
}
