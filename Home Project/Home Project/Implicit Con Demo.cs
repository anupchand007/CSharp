using System;


namespace Constructor
{

        //IMPLICIT CONSTRUCTOR DEMO 
        class ImplicitConstructor
    {
            int i; bool b;
            static void Main()
            {
            ImplicitConstructor newObj = new ImplicitConstructor();
                Console.WriteLine(newObj.i);
                Console.WriteLine(newObj.b);
            Console.WriteLine("The Implicit Constructor is Called ;)");
                Console.ReadLine();
            }
        }
    }
