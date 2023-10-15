// Задача 25
// int DigitMultiplication(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result *= a; // я тут долго тупил, пока не вспомнил про оператор "*="  =))
//     }
//     return result;
// }

// System.Console.Write("Input A value: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input B Value: ");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DigitMultiplication(a, b));
// =================================================================

// задача 27
// int DigitalSum(int num)
// {
//     int sum = 0;
//     while(num > 0)
//     {
//         sum += num % 10;
//         num = num / 10;
//     }

//     return sum;
// }
// System.Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DigitalSum(num));
// =================================================================

// Задача 29
// Уже решали её:
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size]; // инициализация массива
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max Value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, min, max));
// =====================================================

// Задача 29
// упрощенная версия решения задачи.
int[] FillArray(int size)
{
    int[] array = new int[size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int size = 8;

PrintArray(FillArray(size));