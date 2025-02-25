namespace Chapter_WISE
{
    internal class Interfaces
    //Interface allows to inhertis multiple classes as shown below;
    // We use I + class name while writing for E.g: IPerson, IPrey, IPredator 

    {
        interface IPrey
        {
            public void Run();      //decalaring method but not implementating

        }
        interface IPredator
        {
            public void Hunt();     //decalaring method but not implementating
        }

        class Rabbit : IPrey        //Rabbit is a prey which is hunt by many animals
        {
            public void Run()
            {
                Console.WriteLine("The Rabbit runs to safety");
            }
        }

        class Hawk : IPredator      //Hawk is a Predator which is hunts smaller animals
        {
            public void Hunt()
            {
                Console.WriteLine("The Hawk is searching for Food");
            }
        }

        class Fish : IPrey, IPredator       //the fish is a prey as well as hunter so, It sometimes run and hunts;
        {

            public void Run()
            {
                Console.WriteLine("The Fish runs aways from Bigger fish");
            }

            public void Hunt()
            {
                Console.WriteLine("The Fish hunts the smaller fish");
            }
        }


        class InterfaceProgram
        {
            static void Main()
            {
                Rabbit rabbit = new Rabbit();
                rabbit.Run();
                //rabbit.Hunt();      //we will get error it only inhertis one class i.e IPrey

                Hawk hawk = new Hawk();
                //hwak.Run();         //we will get error it only inhertis one class i.e IPredator
                hawk.Hunt();

                Fish fish = new Fish();     // in this well can use both classes with the help of Interface
                fish.Run();
                fish.Hunt();
            }
        }



    }
}
