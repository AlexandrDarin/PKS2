using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество воды (мл): ");
        int water = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество молока (мл): ");
        int milk = int.Parse(Console.ReadLine());
        
        int americanoCount = 0;
        int latteCount = 0;
        int earnings = 0;
        
        while (true)
        {
            Console.WriteLine("\nВыберите напиток:");
            Console.WriteLine("1 - Американо (300 мл воды, 150 руб)");
            Console.WriteLine("2 - Латте (30 мл воды, 270 мл молока, 170 руб)");
            Console.WriteLine("0 - Завершить работу");
            Console.Write("Ваш выбор: ");
            
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 0) break;
            
            switch (choice)
            {
                case 1:
                    if (water >= 300)
                    {
                        water -= 300;
                        americanoCount++;
                        earnings += 150;
                        Console.WriteLine("Ваш напиток готов!");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает воды");
                    }
                    break;
                    
                case 2:
                    if (water >= 30 && milk >= 270)
                    {
                        water -= 30;
                        milk -= 270;
                        latteCount++;
                        earnings += 170;
                        Console.WriteLine("Ваш напиток готов!");
                    }
                    else if (water < 30)
                    {
                        Console.WriteLine("Не хватает воды");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает молока");
                    }
                    break;
                    
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
            
            // Проверка возможности приготовления напитков
            bool canMakeAmericano = water >= 300;
            bool canMakeLatte = water >= 30 && milk >= 270;
            
            if (!canMakeAmericano && !canMakeLatte)
            {
                Console.WriteLine("\nИнгредиенты подошли к концу!");
                break;
            }
        }
        
        // Отчет
        Console.WriteLine("\n=== ОТЧЕТ ===");
        Console.WriteLine($"Остаток воды: {water} мл");
        Console.WriteLine($"Остаток молока: {milk} мл");
        Console.WriteLine($"Приготовлено американо: {americanoCount}");
        Console.WriteLine($"Приготовлено латте: {latteCount}");
        Console.WriteLine($"Итоговый заработок: {earnings} руб");
    }
}
