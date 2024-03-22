



namespace SessionTask_Bike.Models
{
    internal class Bike
    {
        public int BikeId { get; set; }
        public string? BikeName { get; set; }
        public string? BikeModel { get; set; }

        //default constructor
        public Bike(){
            
        }
        //parameterized Constructor
        public Bike(int bikeId, string bikeName, string bikeModel)
        {
            BikeId = bikeId;
            BikeName = bikeName;
            BikeModel = bikeModel;
        }

        //accepting Bike Deatils
        public void AcceptBikeDetails()
        {
            Console.WriteLine("Enter Bike ID");
            BikeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bike Name");
            BikeName = Console.ReadLine();
            Console.WriteLine("Enter the Model");
            BikeModel = Console.ReadLine();

        }

        //displaying Bike Details
        public void DisplayBikeDetails()
        {
            Console.WriteLine("Displaying Bike Details");            
            Console.WriteLine($"BikeId: {BikeId}\nBikeName: {BikeName}\nModel: {BikeModel}");
           
        }

    }
}
