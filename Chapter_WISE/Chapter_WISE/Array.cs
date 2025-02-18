namespace Chapter_WISE
{
    class Array
    {
        static void Main()
        {
            string[] Name = { "Anup", "Bimal", "Niroj" }; //array direct implementation
            int[] Marks = { 84, 81, 84 };
            int[] Age = new int[3];                         // Declaring an array of size 3
            Console.WriteLine("Please Enter the age of Persons:");
            Age[0] = Convert.ToInt32(Console.ReadLine());       //assiging value
            Age[1] = Convert.ToInt32(Console.ReadLine());
            Age[2] = Convert.ToInt32(Console.ReadLine());
            foreach (string name in Name)                       //using loop to print the value of array
            {
                Console.WriteLine($"The name of the person is {name}");
            }

            foreach (int age in Age)
            {
                Console.WriteLine($"The Age of the person is {age}");
            }
        }
    }
}
