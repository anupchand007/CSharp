using System;


namespace Home_Project
{
    internal class Addition
    {
        public int add(int x, int y)
        {
            return x + y;
        }
    }

    internal class Multiply
    {
        public int mul(int x, int y)
        {
            return x * y;
        }
    }


    class Calculator{
    static void Main()
        {
            Addition sum = new Addition();
            int additiom = sum.add (1, 2);
            Console.WriteLine("The result of Addition is " + additiom);

            Multiply mul = new Multiply();
            int Multiplye = mul.mul(1, 2);
            Console.WriteLine("The result of Multiplication is "+Multiplye);
            Console.ReadLine();

        }
    }

}
