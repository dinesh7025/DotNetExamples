using Classes_Example.Models;

namespace Classes_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Creation of object and instances
           Pirate pirate1  = new Pirate();
            pirate1.name = "Monkey.D Luffy";
            pirate1.age = 19;
            pirate1.crew = "Straw Hat pirates";
            pirate1.position = "Captain";
            pirate1.bounty = 30000000000;
            pirate1.powerUser = true;
            pirate1.title = "Emperor of the Sea";

            Console.WriteLine(pirate1.name+"\n"+pirate1.title);
            pirate1.getPirateInfo();
            
            //using parameterized cinstructor
            Pirate pirate2 = new Pirate("Roronoa Zoro", 25, "Straw Hat Pirates", "Vice Captain");
            pirate2.getPirateInfo();
        }
    }

    
}
