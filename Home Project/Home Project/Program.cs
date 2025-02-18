class Cons
{

    static int y;
    int x;

    static Cons()
    {
        Console.WriteLine("The static Con is calledl ;) ");
    }

    public Cons(){
        Console.WriteLine("The non-static Con is calledl ;) ");
    }
    static void Main(){
        Console.WriteLine("The Main Method is called ");
        Cons o1 = new Cons();
        Console.ReadLine();
    
    }
}