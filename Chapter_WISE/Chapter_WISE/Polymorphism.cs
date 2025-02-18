namespace Chapter_WISE
{
    class Polymorphism
    {
        string name = "";
        int age = 0;
        public void setData(string x, int y)
        {
            this.name = x;
            this.age = y;
        }

        public virtual void showdata()
        {
            Console.WriteLine($"The name of the person is {this.name}, while there age is {this.age}");
        }
    }

    class Purvi : Polymorphism
    {
        public override void showdata()
        {
            //base.showdata();
            Console.WriteLine("The name is Purvi");
        }
    }

    class PrintPoly { 
    
        static void Main()
        {
            Purvi p1 = new Purvi();
            p1.setData("Anup Chand", 22);
            p1.showdata();

        }
    }

}
