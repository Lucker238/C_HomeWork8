// ** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение
// двух матриц.


int[,] newArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
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

bool checkSoglasovannost(int[,] arr1, int[,] arr2)
{
    return arr1.GetLength(1) == arr2.GetLength(0);
}

int[,] matrixMulti(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int N = 0; N < arr1.GetLength(1); N++)
            {
                result[i,j] += arr1[i, N] * arr2[N, j];
            }
        }
    }
    return result;
}

Console.Clear();

System.Console.Write("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество строк второй матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов второй матрицы: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array1 = newArray(m, n);
int[,] array2 = newArray(x, y);
showArray(array1);
System.Console.WriteLine();
showArray(array2);
System.Console.WriteLine();
if(checkSoglasovannost(array1, array2)) showArray(matrixMulti(array1,array2));
else System.Console.WriteLine("Матрицы несогласованны!");