using System;

    namespace Constructor
{
        //COPY CONSTRUCTOR

        class CopyConDemo
        {
            string x = "Null";
            public CopyConDemo(string a)
            {
                this.x = a;
                string name = x;
            }
            public void Display()
            {
                Console.WriteLine("The name of the Person is " + x);
            }

            public CopyConDemo(CopyConDemo obj)
            {
                x = obj.x;
            }

        }

        class CopyConstructor()
        {
            static void Main()
            {

                CopyConDemo obj1 = new CopyConDemo("Aarav Chand");
                obj1.Display();
                CopyConDemo obj2 = new CopyConDemo(obj1);
                obj2.Display();
            Console.WriteLine("The Copy Constructor is Called ;)");
                Console.ReadLine();

            }
        }

    }

