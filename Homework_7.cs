// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("Введите количество строк:");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
PrintArray1(GetArray1(rows1, columns1, -10, 10));

// --------------Methods---------

double[,] GetArray1(int m, int n, int minValue, int maxValue)
{
    double[,] Array1 = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { Array1[i, j] = Math.Round((new Random().NextDouble() * (maxValue - minValue) + minValue),1); }
    }
    return Array1;
}

void PrintArray1(double[,] Array1)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        { Console.Write($"{Array1[i, j]} "); }
        Console.WriteLine();
    }
}

// // Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число 
// // в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// не понимаю понимаю, в какой строке в методе Check надо поставить break,чтобы правильно работало после нахождения 
// в массиве первого экземпляра искомого числа. Илт нужно было бы весь метод обернуть в цикл while, чтобы 
// break прерывал этот while?

Console.WriteLine("Введите количество строк:");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число:");
int number = Convert.ToInt32(Console.ReadLine());
int[,] massiv = GetArray2(rows2, columns2, 0, 20);
PrintArray2(massiv);
if(Check(massiv, number))
{Console.WriteLine($"Число {number} есть в массиве");}
else
{Console.WriteLine($"Числа {number} в массиве нет");}

// // ---------Methods-----------

int [,] GetArray2 (int m, int n, int minValue, int maxValue)
{
    int[,] array2 = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array2;
}

void PrintArray2(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

bool Check(int[,] array2, int number)
{   
    {for(int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if(array2[i,j] == number) return true;
        }
    }
    return false;
}
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк:");
int rows3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] massiv3 = GetArray3(rows3, columns3, 0, 10);
PrintArray3(massiv3);
double[] average = Average(massiv3);
Console.WriteLine($"[{String.Join("; ", average)}] - средние арифметические столбцов массива");

// // --------------Methods----------

int[,] GetArray3(int m, int n, int minValue, int maxValue)
{
    int[,] array3 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array3[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array3;
}

void PrintArray3(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] array) // Находим среднее значение по столбцам
{
    double[] col = new double[array.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        col[i] = Math.Round((double)sum / array.GetLength(0), 1);
        sum = 0;
    }
    return col;
}

