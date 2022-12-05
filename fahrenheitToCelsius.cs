using System;
class FahrenheitToCelsius
{
    static float  temp(float t)
    
    {
        float C = (t - 32) / 1.8f;
        return C;
    }
    static void Main(String[] args)
    {
        Console.WriteLine(temp(60));
    }
}