namespace Home_Project
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Most of the Animals have 4 legs and walks on their legs. ");
        }

        public virtual void TypesOfAnimal()
        {
            Console.WriteLine("Most of the animals are Domestic Animals.");
        }
    }

    class Cow : Animal
    {
        public Cow()
        {
            Console.WriteLine("Cow make a MoooWooo sound");
        }
        public  override void TypesOfAnimal()
        {
            Console.WriteLine("Cows are Domestic Animals.");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog make a Bark Souund");
        }

        public override void TypesOfAnimal()
        {
            Console.WriteLine("Dogs are Domestic Animals.");
        }
    }

    class Info
    {
        static void Main()
        {

            Animal Animals = new Animal();
            Animals.TypesOfAnimal();
            Cow c = new Cow();
            c.TypesOfAnimal();
            Dog d = new Dog();
            d.TypesOfAnimal();
            Console.ReadLine();


        }
    }
}
