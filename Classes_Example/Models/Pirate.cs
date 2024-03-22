

using System.Numerics;

namespace Classes_Example.Models
{
    internal class Pirate
    {
        public string name;
        public int age;
        public string crew;
        public string position;
        public BigInteger bounty;
        public bool powerUser;
        public string title;

        //declare a method
        public void getPirateInfo()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nPosition: {position}\nCrew: {crew}");
        }

        // default constructor
        public Pirate()
        {

        }
        // parameterized constructor
        public Pirate(string name, int age, string crew, string position)
        {
            this.name = name;
            this.age = age;
            this.crew = crew;
            this.position = position;
        }

    }
}
