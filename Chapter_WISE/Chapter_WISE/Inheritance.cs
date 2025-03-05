namespace Chapter_WISE
{
    //Inheritance refers to having all the methods of a Parent Class to Child class

    class Person
        
    {
        string Name = "";
        int Age = 0;
        public void Setdata(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Showdata()
        {
            Console.WriteLine($"The name of the person is {this.Name}, while his age is {this.Age}");
        }

    }

    class Anup : Person // ":" is used to represet the inheritance 
    {
        public Anup()
        {
            //base.Showdata();
            Console.WriteLine("This will be automatically called bcz of Default Constructor");
        }
    } 


    class Inheritance { 
    //static void Main()
    //    {
    //        Person p1 = new Person();
    //        p1.Setdata("Anup Chand", 22);
    //        p1.Showdata();

    //        Anup a1 = new Anup();
    //        a1.Setdata("Purvi", 22);
    //        a1.Showdata();
    //    }
    }
}
