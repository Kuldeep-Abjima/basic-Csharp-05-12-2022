using System;
using System.Linq;
/// <summary>
/// this an array class
/// </summary>
class MyFirstArray

{
    static void Main(String[] args)
    {
        Console.WriteLine("enter the size of an array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Enter the elements in Array : ");
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("your array is : ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i] + " ");
        }
        Console.WriteLine("Sum of all Array Elements Are method 1 : ");
        int sum = 0;
            for(int i = 0; i < a.Length; i++)
        {
            sum = sum + a[i];
        }

        Console.WriteLine(sum);

        Console.WriteLine("Sum of all Array Elements Are method 2 : ");
        var SUM = a.Aggregate(0, (total, num) => total + num);
        Console.WriteLine(SUM);

    }
  
}