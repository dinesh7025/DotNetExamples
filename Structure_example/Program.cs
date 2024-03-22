
namespace Structure_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Tanjiro kamado",
                Addr = new Address()
                {
                    DoorNo = "No.90",
                    StreetName = "Festival Street",
                    City = "Japan",
                    PostalCode = "892827"
                }
            };

            //Printing
            Console.WriteLine($"ID: {student1.Id}\nName: {student1.Name}\nAddress: {student1.Addr.DoorNo},{student1.Addr.StreetName},{student1.Addr.City},{student1.Addr.PostalCode}");
        }
    }
}
