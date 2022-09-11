// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.

bool Contains(int[] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a) return true;
    }
    return false;
}

int[] twoNumbersMassiv(int len)
{
    int[] result = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        int b = rnd.Next(10, 100);
        if (Contains(result, b)) i--;
        else result[i] = b;
    }
    return result;
}

int[,,] trexmernMatrix(int x, int y, int z, int[] array)
{
    int[,,] result = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = array[count];
                count++;
            }
        }
    }
    return result;
}

void showArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                System.Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
            }
        }
    }
}

System.Console.Write("Введите длинну массива по координате X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длинну массива по координате Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите длинну массива по координате Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[] helpArray = twoNumbersMassiv(x*y*z);
showArray(trexmernMatrix(x, y, z, helpArray));