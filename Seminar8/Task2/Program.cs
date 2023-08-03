//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] testArray = FillIntArray(5, 2);
Print2dIntArray(testArray);
FindRowWithMinSumOfElements(testArray);


int[,] FillIntArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

void Print2dIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,8}", array[i, j]));
        }
        Console.WriteLine();
    }
}

void FindRowWithMinSumOfElements(int[,] array)
{
    int row = 0;
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        if (tempSum < sum)
        {
            row = i;
            sum = tempSum;
        }
    }
    Console.Write($"Строка с наименьшей суммой элементов: {row+1}");
}
