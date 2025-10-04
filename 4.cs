using System;

class Program
{
    static void Main()
    {
        int low = 0;
        int high = 63;
        int questions = 0;
        
        Console.WriteLine("Загадайте число от 0 до 63 и отвечайте на вопросы:");
        Console.WriteLine("1 - да, 0 - нет\n");
        
        while (low < high && questions < 7)
        {
            int mid = (low + high) / 2;
            Console.Write($"Ваше число больше {mid}? ");
            int answer = int.Parse(Console.ReadLine());
            
            if (answer == 1)
                low = mid + 1;
            else
                high = mid;
            
            questions++;
        }
        
        Console.WriteLine($"\nВы загадали число: {low}");
        Console.WriteLine($"Угадано за {questions} вопросов");
    }
}
