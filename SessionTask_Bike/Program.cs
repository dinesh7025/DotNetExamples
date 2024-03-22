using SessionTask_Bike.Models;
namespace SessionTask_Bike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Bike bike1 = new Bike();
            //methods calling
            bike1.AcceptBikeDetails();
            bike1.DisplayBikeDetails();
            
            //using parameter constructor
            Bike bike2 = new Bike(102, "RoyalEnfield","Continential GT650");
            bike2.DisplayBikeDetails();
            
        }
    }
}
