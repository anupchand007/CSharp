namespace Chapter_WISE
{
    // Base class containing methods that can be overridden or hidden by derived classes
    class BaseClass
    {
        // Virtual method allows it to be overridden in derived classes
        public virtual void Greeting1()
        {
            Console.WriteLine("Greeting from Base Class");
        }

        // Regular method cannot be overridden, only hidden by derived classes
        public void Greeting2()
        {
            Console.WriteLine("Greeting from Base Class");
        }
    }

    // Derived class that inherits from BaseClass
    class DerivedClass : BaseClass
    {
        // Override the Greeting1 method to provide a different implementation
        public override void Greeting1()
        {
            Console.WriteLine("Hello From Derived Class");
        }

        // Hide the Greeting2 method with the 'new' keyword
        public new void Greeting2()
        {
            Console.WriteLine("Hello From Derived Class");
        }
    }

    // Entry point of the program
    class Method_Hiding
    {
        static void Main()
        {
            // Creating an object of DerivedClass but referencing it as BaseClass
            BaseClass obj = new DerivedClass();

            // Calls the overridden method from DerivedClass
            obj.Greeting1();

            // Calls the base class method due to method hiding (not overriding)
            obj.Greeting2();
        }
    }
}
