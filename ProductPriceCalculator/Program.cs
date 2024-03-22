namespace ProductPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Variable declarations
            Console.WriteLine("Enter the Product ID: ");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ProductName: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter the Product Price: ");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            //to calculate total Price
            double totalPrice = productPrice * quantity;
            //calculate GST of 18%
            double gst = totalPrice * 0.18;
            double totalAmount = totalPrice + gst;
            // To give discount
            if (totalAmount > 60000)
            {
                totalAmount = totalAmount - 1000;
            }
            Console.WriteLine("********* BILL *********\n");
            Console.WriteLine($"ProductId: {productId}\nProduct Name: {productName}\nProduct Price: {productPrice}\nProduct Quantity: {quantity}\n Total Price (With GST): {totalAmount}");




        }
    }
}
