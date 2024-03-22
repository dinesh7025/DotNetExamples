using System.Threading.Channels;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction tans1 = new Transaction();
            tans1.checkLimit(10001);
            
        }
    }
}
