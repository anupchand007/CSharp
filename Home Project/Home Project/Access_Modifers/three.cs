using System;

namespace Home_Project.Access_Modifers
{

    //case3 : Accessing all the modifiers using instance from the same class

    class Three
    {
        static void Main(){

            Program p = new Program();
            p.Test2(); p.Test4(); p.Test5();
            Console.ReadLine();
        }  
    }
}
