class Student
{
    private string[] names = new string[3];  // Array to store names

    // Indexer to get and set values
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    //static void Main()
    //{
    //    Student s = new Student();

    //    // Assign values using the indexer
    //    s[0] = "Anup";
    //    s[1] = "Bimal";
    //    s[2] = "Niroj";

    //    // Retrieve values using the indexer
    //    for (int i = 0; i < 3; i++)
    //    {
    //        Console.WriteLine(s[i]);  // Output: Anup, Bimal, Niroj
    //    }
    //}
}
