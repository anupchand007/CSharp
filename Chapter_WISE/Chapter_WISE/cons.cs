namespace Chapter_WISE
{
    class Cons
    {
        //int x = 0;
        public Cons() //This is a Default Constructor which does not have any args
                      //Default Con is called automatically 
        {
            Console.WriteLine("Hello This is a Default Constructor Without any agers");
        }

        public Cons(int x) //This is a Parameterize Constructor which does not have any args
                           //Default Con is called explicitlly  

        {
            Console.WriteLine("This is a Parameterize Constructor with the arg having value " + x);
        }
    }

    class Cosntructors
    {
        //static void Main()
        //{
        //    Cons def1 = new Cons();
        //    Cons para1 = new Cons(22);
        //}
    }
}

