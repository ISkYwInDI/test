using System;

class Program
{
    static void Main ()
    {
        try
        {
            Console.Write("Введите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double max = Math.Max(x, Math.Max(y, z));
            Console.WriteLine($"Максимальное значение: {max}"); 
        }
        catch (Exception ex)
        { 
            Console.WriteLine (ex.Message);
        }
    }
}
