/*Задача 60. ...
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Write("Введите ширину  массива (количество строк)= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину  (количество столбцов) = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива = ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное значение массива = ");
int q = Convert.ToInt32(Console.ReadLine());
int[,,] mass1 = new int[m, n, p];
int[] mass2 = new int[m * n * p];
int y = 0;
for (int i = 0; i < mass2.GetLength(0); i++)
{
    mass2[i] = new Random().Next(q, (m * n * p) + q);
    if (i > 0)
    {
        for (int j = 0; j < i; j++)
        {
            while (mass2[i] == mass2[j])
            {
                mass2[i] = new Random().Next(q, (m * n * p) + q);
                j = 0;
            }
        }
    }
}
for (int k = 0; k < mass1.GetLength(2); k++)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            mass1[i, j, k] = mass2[y];
            y++;
            Console.Write($"{mass1[i, j, k]}({i},{j},{k}) ");           
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
