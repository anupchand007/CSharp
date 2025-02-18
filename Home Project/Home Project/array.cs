namespace Home_Project
{
    class Array
    {
        public void PrintName()
        {
            string[] names = { "Anup", "Bimal", "Sumit" };
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }

        static void Main()
        {
            Array a = new Array();
            a.PrintName();
        }

    }
}
