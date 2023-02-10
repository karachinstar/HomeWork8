/*Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Write("Введите ширину первого массива (количество строк)= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину первого массива (количество столбцов) = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива (количество строк)= ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива (количество столбцов) = ");
int o = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение рандомного числа = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение рандомного числа = ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] mass1 = new int[m, n];
int[,] mass2 = new int[p, o];
if (m == o)
{
    int[,] product = new int[m, o];
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            mass1[i, j] = new Random().Next(min, max);
            Console.Write($"{mass1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < mass2.GetLength(0); i++)
    {
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            mass2[i, j] = new Random().Next(min, max);
            Console.Write($"{mass2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            for (int k = 0; k < mass1.GetLength(1); k++)
            {
                product[i, j] += mass1[i, k] * mass2[k, j];
            }
            //product[i, j] = 
            Console.Write($"{product[i, j]} ");
        }
        Console.WriteLine();
    }
}
else
    Console.WriteLine($"Невозможно перемножить массивы, т.к. кол-во столбцов первого массива ({n}) не равно количеству строк второго массива ({o})"); ;
