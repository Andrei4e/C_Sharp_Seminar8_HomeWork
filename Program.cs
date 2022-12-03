//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/*int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++) 
       {
        array[i,j] = new Random().Next(0, 10);
       }
    }
    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
        Console.Write($"{array[i,j]}  ");
       }
       Console.WriteLine();
    }
}

int[,] OrderArray(int[,] array)
{
    int temp, j_Max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            j_Max = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, j_Max] < array[i, k]) j_Max = k;
            }
            temp = array[i, j];
            array[i, j] = array[i, j_Max];
            array[i, j_Max] = temp;
        }
    }
    return array;
}

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m,n);
Console.WriteLine("Исходный массив:");
ShowArray(array);
Console.WriteLine("Отсортированный по убыванию по строкам:");
ShowArray(OrderArray(array));*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++) 
       {
        array[i,j] = new Random().Next(0, 10);
       }
    }
    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
        Console.Write($"{array[i,j]}  ");
       }
       Console.WriteLine();
    }
}

int MinSumRow(int [,] array)
{
    int sumMin = 2000000, sum = 0 , result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sum += array[i,j];
        }
        if (sumMin > sum )
        {
            sumMin = sum;
            result = i;
        }
        sum = 0;
    }
    return result;
}

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m,n);
ShowArray(array);
Console.Write($"Строка с наименьшей суммой элементов: {MinSumRow(array)}");*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] FillSpiralrray(int m, int n)
{
    int[,] array = new int[m, n];
    int i = 0, j = 0, k = 2, way = 0; // way = 0 - направо / 1 - вниз / 2 - налево / 3 - вверх
    array[i, j] = 1;
    while (k <= m*n)
    {
        switch (way)
        {
            case 0:
                {
                    if (j + 1 < array.GetLength(1)) //& array[i, j + 1] != 0
                    {
                        if (array[i, j + 1] == 0)
                        {
                            array[i, j + 1] = k;
                            j++;
                            k++;
                        }
                        else way++;
                    }
                    else way++;
                    break;
                }
            case 1:
                {
                    if (i + 1 < array.GetLength(0)) // & array[i + 1, j] != 0
                    {
                        if (array[i + 1, j] == 0)
                        {
                            array[i + 1, j] = k;
                            i++;
                            k++;
                        }
                        else way++;
                    }
                    else way++;
                    break;
                }
            case 2:
                {
                    if (j - 1 >= 0) // & array[i, j - 1] != 0
                    {
                        if (array[i, j - 1] == 0)
                        {
                            array[i, j - 1] = k;
                            j--;
                            k++;
                        }
                        else way++;
                    }
                    else way++;
                    break;
                }
            case 3:
                {
                    if (i - 1 >= 0) // & array[i - 1, j] != 0
                    {
                        if (array[i - 1, j] == 0)
                        {
                            array[i - 1, j] = k;
                            i--;
                            k++;
                        }
                        else way = 0;
                    }
                    else way = 0;
                    break;
                }
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(FillSpiralrray(m, n));