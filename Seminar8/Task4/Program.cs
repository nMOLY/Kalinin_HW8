//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.WriteLine("Введите размерность трехмерного массива");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
if (x*y*z <= 90)
{
    int[,,] array = Fill3dArray(x,y,z);
    PrintArray(array);
}
else Console.WriteLine("Нельзя при данных параметрах и условия задачи сформировать массив");


int[,,] Fill3dArray(int m, int n, int k)
{
    int[,,] array = new int[m,n,k];
    Dictionary<int, int> repeatingNumbers = new Dictionary<int, int>();
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            for(int z = 0; z < k; z++)
            {
                int temp = new Random().Next(10, 100);
                if (!repeatingNumbers.ContainsKey(temp)) 
                {
                    repeatingNumbers.Add(temp, 0);
                    array[x,y,z] = temp;
                }
                else z--;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"{array[x,y,z]} ({x}, {y}, {z})");
            }
        }
    }
}