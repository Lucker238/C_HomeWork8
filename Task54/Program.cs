//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] sortedArray(int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int N = 0;
        while (N < array.GetLength(1))
        {
            for (int j = N; j < array.GetLength(1); j++)
            {
                int min = array[i, N];
                int minInd = N;
                if (result[i, j] < min)
                {
                    min = result[i, j];
                    minInd = j;
                }
                result[i, minInd] = result[i, j];
                result[i, j] = min;
            }
            N++;
        }
    }
    return result;
}


System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = newArray(m, n);
showArray(array);
System.Console.WriteLine();
showArray(sortedArray(array));