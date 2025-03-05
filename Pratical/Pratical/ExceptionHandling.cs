using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 4;

            if (b == 0)
            {
                throw new Exception("Cannot be divied by zero");
            }
            int result = a / b;
            Console.WriteLine("The Result is " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("The Code is Executed!!");
        }
    }
}