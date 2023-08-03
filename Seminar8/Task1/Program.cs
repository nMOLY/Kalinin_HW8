//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] testArray = FillIntArray(5, 5);
Print2dIntArray(testArray);
Console.WriteLine();
int[,] newArray = Sort2dArray(testArray);
Print2dIntArray(newArray);



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

int[,] Sort2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int tempMinValue = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = tempMinValue;
                }
            }
        }
    }
    return array;
}
