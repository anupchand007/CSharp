using System;

namespace Home_Project.Access_Modifers
{
    // Case 1 Accessing all the modifiers from the same class //

    class Program
    {
        private void Test1(){
            Console.WriteLine("1. Private Modifier is called.");
        }

        internal void Test2()
        {
            Console.WriteLine("2. Internal Modifier is called.");
        }

        protected  void Test3()
        {
            Console.WriteLine("3. Protected Modifier is called.");
        }

        protected internal void Test4()
        {
            Console.WriteLine("4. Protected Inertal Modifier is called.");
        }

        public void Test5(){
            Console.WriteLine("5. Public Modifier is called.");
        }

        static void Main()
        {

            Program a = new Program();
            a.Test1(); a.Test2(); a.Test3(); a.Test4(); a.Test5();
            Console.ReadLine();

        }
    } 
}
