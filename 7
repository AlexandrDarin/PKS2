using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.Write("Введите количество модулей (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите размеры модуля (a b): ");
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        Console.Write("Введите размеры поля (h w): ");
        input = Console.ReadLine().Split();
        int h = int.Parse(input[0]);
        int w = int.Parse(input[1]);

        // Вычисление максимальной толщины защиты
        int maxD = CalculateMaxProtection(n, a, b, h, w);

        Console.WriteLine($"Максимальная толщина защиты: {maxD}");
    }

    static int CalculateMaxProtection(int n, int a, int b, int h, int w)
    {
        // Проверяем возможность размещения без защиты
        if (!CanPlaceModules(n, a, b, h, w, 0))
            return -1; // Размещение невозможно

        // Бинарный поиск максимальной толщины
        int left = 0;
        int right = Math.Min(h, w);
        int result = 0;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (CanPlaceModules(n, a, b, h, w, mid))
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }

    static bool CanPlaceModules(int n, int a, int b, int h, int w, int d)
    {
        // Размеры модуля с защитой
        int aWithD = a + 2 * d;
        int bWithD = b + 2 * d;

        // Проверяем оба варианта ориентации
        return (h >= aWithD && w >= bWithD && CanFit(n, aWithD, bWithD, h, w)) ||
               (h >= bWithD && w >= aWithD && CanFit(n, bWithD, aWithD, h, w));
    }

    static bool CanFit(int n, int moduleHeight, int moduleWidth, int fieldHeight, int fieldWidth)
    {
        // Максимальное количество модулей по высоте и ширине
        int maxInHeight = fieldHeight / moduleHeight;
        int maxInWidth = fieldWidth / moduleWidth;

        // Общее количество модулей, которые помещаются на поле
        int totalModules = maxInHeight * maxInWidth;

        return totalModules >= n;
    }
}
