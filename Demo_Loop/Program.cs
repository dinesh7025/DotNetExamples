using System.Text;

namespace Demo_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loops syntax
            /* //for Loops
             for (int i=1;i<=10;i++)
                 Console.Write(i);

             //while Loop
             int j = 1;
             while (j < 10)
             {
                 Console.WriteLine("The Value is "+j);
                 j++;
             }
             //Do While Loop
             int k = 1;
             do{
                 Console.WriteLine("The value is " + k);
                 k++;
             }
             while (k < 10);*/
            #endregion
            #region Jump Statements
            //Jump Statements(GoTo and Label)
            /*int counter = 0;
            string pwd = "dinesh@123";
            login:
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            if(pwd != password)
            {
                counter++;
                if (counter > 2)
                {
                    Console.WriteLine("3 attempts are over. Try after sometimes");
                }
                Console.WriteLine("Wrong Password");
                goto login;
            }
            else
            {
                Console.WriteLine("Welcome");
            }*/
            #endregion
            #region String Builder Example
            /* string msg1 = "Hey,";
             string msg2 = "How u'doin?";
             string msg3 = msg1+ msg2;
             Console.WriteLine(msg3);
             //string Builder
             StringBuilder sb = new StringBuilder();
             sb.Append(msg1);
             sb.Append(msg2);
             Console.WriteLine(sb);*/
            #endregion
            #region String Builder and Concat Diff
            //Concatenation string
            /*string s = "";
            DateTime startTime;
            DateTime endTime;
            TimeSpan totalTime;
            startTime = DateTime.Now;
            for (int i = 0; i < 10000;i++) 
            {
                s += i.ToString();
            }
            endTime = DateTime.Now;
            totalTime = endTime - startTime;
            Console.WriteLine("The total time taken is"+totalTime.TotalSeconds);

            //String Builder
            StringBuilder sb = new StringBuilder();
            startTime = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i.ToString());
            }
            endTime = DateTime.Now;
            totalTime = endTime - startTime;
            Console.WriteLine("The total time taken is" + totalTime.TotalSeconds);*/
            #endregion
            #region Anonymous Type
            //Anonymous Type
            /*var car = new
            {
                name = "BMW GTR M3",
                Driver = "Kakarot",
                bounty = 12007000,
                rapsheet = new { busted = 3, warrantType = "National Warrant" }
            };
            Console.WriteLine(car.name);
            Console.WriteLine(car.Driver);
            Console.WriteLine(car.bounty);
            Console.WriteLine(car.rapsheet);*/
            #endregion  

        }
    }
}
