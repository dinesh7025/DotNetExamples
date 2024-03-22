

namespace Structure_example
{
    internal struct Address
    {
        //fields
        public String DoorNo;
        public String StreetName;
        public String City;
        public String PostalCode;

        //Constructor
        public Address(string doorNo,string stName, string city, string pincode)
        {
            DoorNo = doorNo;
            StreetName = stName;
            City = city;
            PostalCode = pincode;
        }
    }
}
