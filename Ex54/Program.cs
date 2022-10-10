// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SelectionSort(int [,] array)      // сортировка
{
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1)-1; j++)
    {
        int maxPos = j;
        for (int k=j+1; k<array.GetLength(1); k++)
        {
            if(array[i,k]>array[i,maxPos]) maxPos=k;
        }

        int temp = array[i,j];
        array[i,j] = array[i,maxPos];
        array[i,maxPos]= temp;
    }
}
}

Console.Write("Введите необходимое количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество cтолбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arrayFor54 = new int [m,n];

FillRandomArray(arrayFor54, 0, 10);
PrintArray(arrayFor54);
Console.WriteLine();
SelectionSort(arrayFor54);
PrintArray(arrayFor54);
