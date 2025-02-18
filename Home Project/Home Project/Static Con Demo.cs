namespace Constructor
{
    class Static_Con_Demo
    {
        static Static_Con_Demo()
        {
            Console.WriteLine("The Static Constructor of Static_Con_Demo is Called.");
        }


    }
    class StaticConstructor
    {
        static void Main()
        {
            Console.WriteLine("Hellow Beautiful World");
            Static_Con_Demo obj1 = new Static_Con_Demo();
            Console.WriteLine("The Static Constructor is Called ;)");
            Console.ReadLine();
        }
    }
}
