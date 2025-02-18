using System;


namespace Class_OBJ
{
    // CLASS AND OBJ

    class Person
    {
        string name = "null";
        int age = 0;

        public void SetName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetName()
        {
            Console.WriteLine("The name of the user is " + this.name + ", his age is " + this.age);
        }
    }


    class Class_Obj
    {
        static void Main()
        {

            Person p1 = new Person();
            p1.SetName("Anup Chand", 21);
            p1.GetName();

        }
    }
}
