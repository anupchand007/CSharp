namespace Chapter_WISE
{
    class Props
    {
        //there are two different kind of methods a. get() and set()

        private string name;    //field

        public string Name
        {
            get { return name; } //The get method returns the value of the variable name.
            set { name = value; } //The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
        }
    }

    //class Properties { 
    //static void Main()
    //    {
    //        Props p1 = new Props();
    //        p1.Name = "Anup Chand";
    //        Console.WriteLine(p1.Name);
    //    }
    //}
}
