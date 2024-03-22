namespace Exception_Handling
{
    internal class Transaction
    {
        int maxLimit = 10000;

        public void checkLimit(int amount)
        {
            try
            {
                if(amount > maxLimit)
                {
                    throw new Exception("Daily limit fo the transaction is exceeded");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);//Print the error message
                Console.WriteLine(e.StackTrace);// call stack
                Console.WriteLine(e.TargetSite);//which mehod gives the error
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
