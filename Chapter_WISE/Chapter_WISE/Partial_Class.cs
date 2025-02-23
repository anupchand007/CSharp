namespace Chapter_WISE
{
    // Partial class allows splitting a class definition into multiple files
    //we use PARTIAL keyword for the partical class
    partial class My_Class
    {
        // Method M1 defined in this part of the partial class
        public void M1()
        {
            Console.WriteLine("My Class M1");
        }
    }

    partial class My_Class
    {
        // Method M2 defined in another part of the partial class
        public void M2()
        {
            Console.WriteLine("My Class M2");
        }
    }

    class PartialClassDemo
    {
        static void Main()
        {
            // Creating an object of the partial class
            My_Class mee = new My_Class();

            // Calling methods from both parts of the partial class
            mee.M2();
            mee.M1();

            Console.ReadLine(); // Keeps console open until input is given
        }
    }
}
