using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    static void Main()
    {
        Console.Write("Введите числитель M: ");
        int M = int.Parse(Console.ReadLine());
        
        Console.Write("Введите знаменатель N: ");
        int N = int.Parse(Console.ReadLine());
        
        if (N == 0)
        {
            Console.WriteLine("Ошибка: знаменатель не может быть нулем");
            return;
        }
        
        int gcd = GCD(Math.Abs(M), Math.Abs(N));
        int simplifiedM = M / gcd;
        int simplifiedN = N / gcd;
        
        if (simplifiedN == 1)
            Console.WriteLine($"Сокращенная дробь: {simplifiedM}");
        else
            Console.WriteLine($"Сокращенная дробь: {simplifiedM}/{simplifiedN}");
    }
}
