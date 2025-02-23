using System.Collections;

namespace Chapter_WISE
{
    internal class Generics
    {
        // Generic method to display elements of an array
        // T is a placeholder for any data type (int, double, string, etc.)


        public static void displayELements<T>(T[] array) //we can refer T as a type, then, T - T[] of array with varaiable name array
        {
            foreach(T i in array)       //T datatype i
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            //generic = "not specific to a particular data type"
            //           add<T> to: classes, methods, fields etc
            //           allows for code reusability for different types

            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0 };
            string[] stringArray = { "1", "2", "3", "4" };

            // Since displayElements is a static method, we can call it directly 
            // without creating an instance of the Generics class.

            displayELements(intArray);
            displayELements(doubleArray);
            displayELements(stringArray);
        }


    }
}
