// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.


int[,] newArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-9, 10);
        }
    }
    return result;
}

void showArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            System.Console.Write($"{input[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[] findMaxString(int[,] array)
{
    int[] result = new int[2];
    int minSum = 0;
    int minStr = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum+= array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minStr = i;
        }
    }
    result[0] = minStr + 1;
    result[1] = minSum;
    return result;
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = newArray(m, n);
showArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Строка {findMaxString(array)[0]} является строкой с наименьшей суммой элементов: {findMaxString(array)[1]}");
