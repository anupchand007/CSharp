namespace Chapter_WISE
{
    class Polymorphism
    {
        string name = "";
        int age = 0;
        public void setData(string x)  // Method 1
        {
            name = x;
            Console.WriteLine($"Name: {x}");
        }
        public virtual void Greeting()  // Base class method (virtual)
        {
            Console.WriteLine("Greeting From Parent/Base Class");
        }

        public void setData(string x, int y)  // Method 2 (Overloaded)
        {
            this.age = y;
            Console.WriteLine($"Name: {x}, Age: {y}");
        }

        public virtual void showdata()
        {
            Console.WriteLine($"The name of the person is {this.name}, while there age is {this.age}");
        }
    }

    class Purvi : Polymorphism
    {
        public override void Greeting()  // Overriding in derived class
        {
            Console.WriteLine("Greeting from Child/Derived Class");
        }
    }

    class PrintPoly
    {
        //static void Main()
        //{
        //    Polymorphism pol1 = new Polymorphism();
        //    pol1.setData("Parent Class", 99);
        //    pol1.Greeting();
        //    pol1.showdata();
        //    Purvi p1 = new Purvi();
        //    p1.setData("Anup Chand", 22);
        //    p1.showdata();
        //    p1.Greeting();

        //}
    }
}
