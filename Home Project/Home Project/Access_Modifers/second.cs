using System;


namespace Home_Project.Access_Modifers
{
    // Case 2: Accessing all the modifiers using child from the same class //
    class Second : Program //inheritance
    {
        static void Main(){

            Second t = new Second();
            t.Test2(); t.Test3(); t.Test4(); t.Test5();
            Console.ReadLine();
        }  
    }
}
