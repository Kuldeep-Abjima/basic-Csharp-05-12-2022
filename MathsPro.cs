using System;
class myFirstApp
{
    static void Sum()
    {
        Console.WriteLine("Enter the First number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a + b;
        Console.WriteLine("Sum of these number : "+ c);
    }
    static void min()
    {
        Console.WriteLine("Enter the First number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a - b;
        Console.WriteLine("Sub of these Number : " + c);
    }
    static void divide()
    {
        Console.WriteLine("Enter the First number");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the Second Number ");
        float b = Convert.ToSingle(Console.ReadLine());
        float c = a/b;
        Console.WriteLine("div of these Number : " + c);
    }
    static void multi()
    {
        Console.WriteLine("Enter the First number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a * b;
        Console.WriteLine("Multiply of these Number : {0}", c);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Sum, Sub, Multiply, Divide");
        String C = Console.ReadLine();
        if(C == "sum" || C =="Sum")
        {
            Sum();
        }
        else if(C == "sub" || C ==  "Sub")
        {
            min();
        }
        else if (C == "Divide" || C == "divide")
        {
            divide();
        }
        else if (C == "multiply" || C == "Multiply")
        {
            multi();
        }
        else
        {
            Console.WriteLine("Error");
        }
        //Console.WriteLine(int.MaxValue);
    }
}