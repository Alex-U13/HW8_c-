// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

void FillRandomArray(int[,]array, int min, int max)   // заполнение массива
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min,max);
        }
    }
}

void PrintArray (int [,] array)       // вывод массива
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}

Console.Write("Введите необходимое количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = new int [m,m];

FillRandomArray(matrix1, 1, 5);
PrintArray(matrix1);
Console.WriteLine();

int [,] matrix2 = new int [m,m];
FillRandomArray(matrix2, 1, 5);
PrintArray(matrix2);

Console.WriteLine();

int [,] Result = new int [m,m];
for(int i=0; i<Result.GetLength(0)-1; i++)
{
    for(int j =0; j<Result.GetLength(1); j++)
    {
        int k = 0;
        Result[i,j] = matrix1[i,k]*matrix2[i,j] + matrix1[i,k+1]*matrix2[i+1,j];
        Console.Write($"{Result[i,j]}  ");
    }
    Console.WriteLine();
 }

 for(int i=1; i<Result.GetLength(0); i++)
{
    for(int j =0; j<Result.GetLength(1); j++)
    {
        int k = 0;
        Result[i,j] = matrix1[i,j]*matrix2[i-1,k] + matrix1[i,k+1]*matrix2[i,k+1];
        Console.Write($"{Result[i,j]}  ");
    }
    Console.WriteLine();
 }