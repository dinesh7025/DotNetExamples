using System.Runtime.InteropServices;

namespace Arrays_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 dimensional array
            /*//Decration of array
            string[] sample;
            sample = new string[5];//will allocate size 5 in memory
            
            //Declare and Initialize
            string[] yonkos = new string[] { "Akgamino Shanks",
                                             "Monkey.D Luffy",
                                             "Buggy The Clown", 
                                             "Marshall.D Teach"
                                            };
            //Access Individual values
            Console.WriteLine(yonkos[3]);
            //Access all values or multiple
            Console.WriteLine("-----ForLoop-----");
            for (int i = 0; i < yonkos.Length; i++)
            {
                Console.Write(yonkos[i]+", ");
            }
            Console.WriteLine();

            //foreach Loop
            Console.WriteLine("-----Foreach Loop-----");
            foreach (string names in yonkos)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine();

            //Sorting
            Console.WriteLine("-----Sorting-----");
            Array.Sort(yonkos);//sort in ascending
            Console.WriteLine("Ascending order");
            foreach (string names in yonkos)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine();

            //to get descending we have to sort it and reverse it
            Console.WriteLine("Descending Order");
            Array.Reverse(yonkos);
            foreach (string names in yonkos)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine();

            //searching
            Console.WriteLine("----Seaching----");
            string itemToBeSearched = "Monkey Luffy";
            //item=>item==itemToBeSearched -- lambda expression
            string searchResult = Array.Find(yonkos, item=>item==itemToBeSearched);
            if (searchResult != null)
            {
                Console.WriteLine(searchResult);
            }
            else
            {
                Console.WriteLine("Item Not found");
            }*/
            #endregion
            #region Multidimensionala Array
            /*//2 dimensional array
            string[,] Waifus =
            {
                {"Yamato","Robin"},
                { "Nezuko","hashira"},
                {"Hinata","Mei" }             
            };
            //Declare array
            int[,] array2d = new int[3, 3];
            //populate values for array
            for(int row =0;row<3;row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    array2d[row, col] = row * 10 + col;
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----Printing array-----");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(array2d[row,col]+"\t");
                }
                Console.WriteLine();
            }*/
            #endregion
            #region Jagged Array
            /*//Jagged Array
            // Initializing and assigning
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            //Accessing
            Console.WriteLine(jaggedArray[0][2]);

            //Printing all values
            // Using foreach to iterate
            Console.WriteLine("----Printing Jagged Array----");
            foreach (int[] items in jaggedArray)
            {
                foreach (int item in items)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }*/
            #endregion
            #region ForLoop Vs ForEach
            //ForLoop and Foreach comparison with array
            int[] numbers = new int[10000];
            //Assign values to array
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            DateTime startTime;
            DateTime endTime;
            TimeSpan forLooptotalTime;
            TimeSpan forEachtotalTime;

            //For Loop Calculation
            startTime = DateTime.Now;
            for (int i = 0;i < numbers.Length;i++)
            {
                int temp = numbers[i];
            }
            endTime = DateTime.Now;
            forLooptotalTime = endTime - startTime;    
            Console.WriteLine($"The Total Time taken by For loop is {forLooptotalTime.TotalSeconds}");
            Console.WriteLine();

            //For each calculation
            startTime = DateTime.Now;
            foreach(int item in numbers)
            {
                int temp = item;
            }
            endTime = DateTime.Now;
            forEachtotalTime = endTime - startTime;
            Console.WriteLine($"The Total Time taken by For loop is {forEachtotalTime.TotalSeconds}");
            Console.WriteLine();
            double minTime = Math.Min(forLooptotalTime.TotalSeconds, forEachtotalTime.TotalSeconds);

             Console.WriteLine($"The minimum time is {minTime}");
            if (forEachtotalTime.TotalSeconds > forLooptotalTime.TotalSeconds)
            {
                Console.WriteLine($"The winner is 'For Loop'");
            }
            else
            {
                Console.WriteLine($"The winner is 'ForEach Loop'");
            }
            #endregion








        }
    }
}
