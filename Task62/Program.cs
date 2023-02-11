/*Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int m = 4;
int n = 4;
int[,] mass1 = new int[m, n];
int y = 1;
int i = 0;
int j = 0;
for (int w = 1; w < m * n; w++)
{
    if (w == 1)
    {
        for (int j1 = 0; j1 < n - 1; j1++)
        {
            mass1[i, j] = y;
            y++;
            j++;
            
        }
        
    }
    else if (w == 2)
    {
        for (int i1 = 0; i1 < m - 1; i1++)
        {
            mass1[i, j] = y;
            y++;
            i++;
        }
        
    }
    else if (w == 3)
    {
        for (int j1 = 0; j1 < m - 1; j1++)
        {
            mass1[i, j] = y;
            y++;
            --j;
        }
        
    }
    else if (w == 4)
    {
        for (int i1 = 0; i1 < m - 1; i1++)
        {
            mass1[i, j] = y;
            y++;
            --i;
        }
        --i;
        
    }
    else if (w == 5)
    {
        i = 1;
        j = 1;
        for (int j1 = 0; j1 < n - 2; j1++)
        {            
            mass1[i, j] = y;
            y++;
            j++;

        }

    }
    else if (w == 6)
    {
        i = 2;
        j = 2;
        for (int i1 = 0; i1 < m - 3; i1++)
        {
            mass1[i, j] = y;
            y++;
            i++;
        }

    }
    else if (w == 7)
    {
        i = 2;
        j = 1;
        for (int j1 = 0; j1 < m - 3; j1++)
        {
            mass1[i, j] = y;
            y++;
            --j;
        }

    }
}

for (int k = 0; k < mass1.GetLength(0); k++)
{
    for (int l = 0; l < mass1.GetLength(1); l++)
    {
        if (mass1[k, l] < 10)
            Console.Write($"0{mass1[k, l]} ");
        else
            Console.Write($"{mass1[k, l]} ");
    }
    Console.WriteLine();
}



