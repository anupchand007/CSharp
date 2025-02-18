using System;


namespace Constructor
{
    //EXPLICIT CONSTRIUCTOR DEMO

    class Expli_Cons_Demo
    {
        public Expli_Cons_Demo(int i)
        {
            Console.WriteLine("The Constructor is Called " + i);
        }
        }
    class ExplicitConstructor
    {
        static void Main()
        {

            Expli_Cons_Demo newObj = new Expli_Cons_Demo(10);
            Console.WriteLine("The Explicit Constructor is Called ;)");
            Console.ReadLine();

        }

    }
}
