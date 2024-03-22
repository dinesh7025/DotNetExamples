namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\C# Training(.NET)\DotNetExamples\sample.txt";
            /*if(File.Exists(filePath))
            {
                Console.WriteLine("File Already Exists");
            }*/
            //File.Create(filePath);
            //Console.WriteLine("File Created Succrsfully");
            File.WriteAllText(filePath, "Hey!, How'u do'in");

            //Create Directory
            /*string directoryPath = @"D:\Newfolder";
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }*/

            //Create Object for FileInfo
            FileInfo fi = new FileInfo(filePath);
            FileStream fs = fi.OpenRead();
            


        }
    }
}
