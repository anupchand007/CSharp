//using Home_Project;

//class DelegateExample
//{
//   public delegate void Calculator(int x, int y);

//    public void Sum(int a, int b)
//    {
//        Console.WriteLine("The result of sum is  " + (a + b));
//    }

//    public void Mul(int a, int b)
//    {
//        Console.WriteLine("The result of mul is " + (a * b));
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        DelegateExample obj = new DelegateExample();
//        DelegateExample.Calculator c = new DelegateExample.Calculator(obj.Sum);
//        c(20, 30);
//        c += obj.Mul;
//        c(10, 20);

//        //c = obj.Mul;
//        //c(10, 20);
//    }
//}


delegate void Msg(string m);

class ShowMessage
{
    public void Message(string a)
    {
        Console.WriteLine(a);
    }
}
class Program
{
    static void Main()
    {
        ShowMessage m = new ShowMessage();
        Msg DM = new Msg(m.Message);
        DM("Hello There");
    }
}