// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Введите необходимое количество строк/cтолбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] arrayFor62 = new int [m,m];
int value =10;
for(int i = 0; i < arrayFor62.GetLength(0); i++)
{
    for( int j=0; j<arrayFor62.GetLength(1); j++)
    {
        arrayFor62[i,j] = value+j;
        Console.Write($"{arrayFor62[i,j]}; ");
    }
    Console.WriteLine();
    value=arrayFor62[i, arrayFor62.GetLength(1)-1]+1;
}