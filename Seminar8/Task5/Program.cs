//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
Console.WriteLine("Работает только с квадратными массивами");
int m = 10;
int n = 10;
int[,] array = SpiralArray(m, n);
Print2dIntArray(array);


int[,] SpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int count = 1;
    int temp_m = m;
    int temp_n = n;
    int temp_i = 0;
    while (temp_n != 0 && temp_m != 0)
    {
        for (int j = temp_i; j < temp_n; j++)
        {
            array[temp_i, j] = count;
            count++;
        }
        for (int i = temp_i+1; i < temp_m; i++)
        {
            array[i, temp_m - 1] = count;
            count++;
        }
        for (int r = temp_n - 2; r > temp_i-1; r--)
        {
            array[temp_m - 1, r] = count;
            count++;
        }
        for (int k = temp_m - 2; k > temp_i; k--)
        {
            array[k, temp_i] = count;
            count++;
        }
        temp_i++;
        temp_m--;
        temp_n--;
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
