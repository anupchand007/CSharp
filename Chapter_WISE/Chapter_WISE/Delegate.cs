namespace Chapter_WISE
{
    // Define a delegate named StringDelegate that takes a string argument and returns void
    public delegate void StringDelegate(string text);

    class Delegate
    {
        // Method that converts the text to uppercase and prints it
        static void ToUpperCase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        // Method that converts the text to lowercase and prints it
        static void ToLowerCase(string text)
        {
            Console.WriteLine(text.ToLower());
        }

        // Method that prints the original text and then applies the delegate to process it
        static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}"); // Prints the original text
            stringDelegate(text); // Calls the delegate method to process the text
        }

        static void Main()
        {
            // Create a delegate instance pointing to the ToUpperCase method
            StringDelegate stringDelegate = ToUpperCase;

            // Uncomment this line to call ToUpperCase directly via the delegate
            //stringDelegate("this is lower case");

            // Uncomment the following lines to use ToLowerCase via another delegate
            StringDelegate stringDelegate2 = ToLowerCase;
            stringDelegate2.Invoke("this is upper case");       //using invoke method

            // Call WriteOutput with the "stringDelegate" (ToUpperCase method)
            WriteOutput("This is a lower case", stringDelegate);
        }
    }
}
