namespace Variables
{
    class Program
    {
        int x = 100;            //Non-Static Variable
        static int y = 200;     //Static Variable
        const float pi = 3.14f; //constant Variable
        readonly bool flage = true;
        static void Main(string[] args)
        {
            //we can only call Non-static varible by creating a instance but Static does not req.

            // if we try to call we will get error for static variable
            Program p = new Program();
            Console.WriteLine(p.x);

            Console.WriteLine(pi); //since it is a const making new isntance or decela ring it will waste memory so it can be directly printed.


            Console.WriteLine(y);
            Console.WriteLine(p.flage);   
            Console.ReadLine();

        }
    }
}