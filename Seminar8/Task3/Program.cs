//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = FillIntArray(2, 2);
int[,] array2 = FillIntArray(2, 2);
if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.Write("Невозможно посчитать переданные массивы как матрицу");
}
else
{
Print2dIntArray(array1);
Console.WriteLine("");
Print2dIntArray(array2);
Console.WriteLine("");
Matrix(array1, array2);
}



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


void Matrix(int[,] array1, int[,] array2)
{
    int a = array1.GetLength(0);
    int b = array1.GetLength(1);
    int c = array2.GetLength(0);
    int d = array2.GetLength(1);
    int[,] matrix = new int[a, d];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < d; j++)
            {
                for (int n = 0; n < b; n++)
                {
                    matrix[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    Print2dIntArray(matrix);
}

