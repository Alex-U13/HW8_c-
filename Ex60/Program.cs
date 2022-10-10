// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();

void FillRandomArray(int[,,]array, int min, int max)   // заполнение массива
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(2); k++)
            {
            array[i,j,k] = new Random().Next(min,max);
            }
        }
    }
}

void PrintArray (int [,,] array)       // вывод массива
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
           for (int k = 0; k<array.GetLength(2); k++)
            {
           Console.Write($"{array[i,j,k]} ({i} , {j} ,{k}); ");
            }
            Console.WriteLine();
        }
        
    }

}

Console.Write("Введите необходимое количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество cтолбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество ________  массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int [,,] arrayFor60 = new int [m,n,l];

FillRandomArray(arrayFor60, 0, 10);
PrintArray(arrayFor60);
