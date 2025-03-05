namespace Chapter_WISE
{
    //indexers are used to treat objects like array

    class IndexerDemo
    {
        private int[] StudentAge = new int[10];     //inderxer allow us to access private fields

        public int this[int i]      //this refers to the StudentAge in line 5, while int is datatype and i is a variable, it can be anything
        {
            get { return StudentAge[i]; }
            set { StudentAge[i] = value; }
        }
    }

    class InderxerString {
        //      
        private string[] StudentNames = new string[10];


        public string this[int i] //int i is the type of i
        //     string is type of StudentNames
        {
            get { return StudentNames[i]; }
            set { StudentNames[i] = value; }
        }
    
    }

    class Indexer
    {
        //static void Main()
        //{

        //    IndexerDemo demo = new IndexerDemo();
        //    demo[0] = 25;
        //    demo[2] = 45;
        //    demo[4] = 35;
        //    demo[6] = 75;
        //    //Console.WriteLine($"The values of Students are {demo[0]},{demo[2]}, {demo[4]}, {demo[6]}");

        //    InderxerString demo2 = new InderxerString();
        //    demo2[2] = "Anup Chand";
        //    demo2[4] = "Purvi Shrestha";
        //    demo2[6] = "Aarav Chand";

        //    Console.WriteLine($"The name and age of the {demo2[2]} student is {demo[2]}");
        //    Console.WriteLine($"The name and age of the {demo2[4]} student is {demo[4]}");
        //    Console.WriteLine($"The name and age of the {demo2[6]} student is {demo[6]}");
        //}
    }
}
