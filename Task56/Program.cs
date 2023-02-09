/*Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 
Например, задан массив:
 
1 4 7 2
 
5 9 2 3
 
8 4 2 4
 
5 2 6 7
 
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Write("Введите длину массива (количество столбцов) = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива (количество строк)= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение рандомного числа = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение рандомного числа = ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
int[] temp = new int[m];
int[] temp2 = new int[m];
int minzn = 0;
int minin = m;
int sum = 0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(min, max);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
if (n <= m)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            temp2[j] = num[i, j];
            sum += temp2[j];
        }
        temp[i] = sum;
        sum = 0;

    }
}
else
{
    for (int j = 0; j < temp2.GetLength(0); j++)
    {
        for (int i = 0; i < temp2.GetLength(0); i++)
        {
            temp2[i] = num[j, i];
            sum += temp2[i];
        }
        temp[j] = sum;
        sum = 0;
    }
}

minzn = temp[temp.GetLength(0) - 1];
if (n <= m)
temp2[n - 1] = m;
else temp2[m - 1] = n;
for (int j = 0; j < temp.GetLength(0); j++)
{

    if (temp[j] > minzn)
    {
        temp2[j] = m;
    }
    else if (temp[j] == minzn)
    {
        temp2[j] = j + 1;
    }
    else
    {
        for (int k = 0; k < temp.GetLength(0); k++)
        {
            temp2[k] = m;
        }
        minzn = temp[j];
        temp2[j] = j + 1;
        minin = j + 1;
    }
}
if (m > 1)
{
    Console.WriteLine("Строки под номерами: ");
    for (int j = 0; j < m; j++)
    {
        if (temp[j] == minzn)
        {
            Console.Write($"{temp2[j]}; ");
        }

    }
    Console.WriteLine();
    Console.WriteLine($"имеют минимальное значение суммы элементов ({minzn})");
}
else Console.WriteLine("имеется только одна строка");
//получилось слишком длинно, но вроде решает все случаи
