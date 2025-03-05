namespace Chapter_WISE
{
    namespace Abstract_Class
    {  //Abstract Class can be inherited but Cannot be instantiated directly.
        abstract class Abstract         //abstract class
        {
            public abstract void Sound();   // Abstract method (no implementation)
        }

        class Dog : Abstract    // Inheriting from abstract class
        {

            public override void Sound() // Implementing abstract method
            {
                Console.WriteLine("The Dog Barks");
            }
        }

        class ShowAbstract
        {
            //static void Main()
            //{
            //    //Abstract a1 = new Abstract();  //This will show error bcz Abstract Class can be inherited but Cannot be instantiated directly.
            //    Dog d1 = new Dog();
            //    d1.Sound();
            //}

        }
    }

    namespace Seal_Class
    {

        sealed class Calculator
        {

            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        //class Sum : Calculator //Calculator cannot be inhertitaed cuz of seal class
        //{

        //}

        class SealClass
        {

            //static void Main()
            //{
            //    Calculator c1 = new Calculator();
            //    Console.WriteLine($"The Result is : {c1.Add(23, 2)}");
            //}

        }

    }
}
