namespace Home_Project
{
    internal class Exceptiom
    {
        static void Main()
        {
            int a = 10, b = 0;

            try
            {
                if(b == 0)
                {
                    Console.WriteLine("Cannot be Divided by zero");
                }
                int result = a / b;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleanup code");
            }
        }

    }
    
}
