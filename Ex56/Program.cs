// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
Console.Write("Введите необходимое количество cтолбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arrayFor56 = new int [m,n];

FillRandomArray(arrayFor56, 0, 10);
PrintArray(arrayFor56);
Console.WriteLine();
int[] workArray = new int[arrayFor56.GetLength(0)];

for (int i =0; i<arrayFor56.GetLength(0); i++)     // заполнение вспомогательного массива с элемеентами из суммы элементов строк arrayFor56
{
    int summ = 0;
    for (int j = 0; j < arrayFor56.GetLength(1); j++)
    {
        summ += arrayFor56[i,j];
    }
    workArray[i] = summ;
    Console.Write($"{workArray[i]}; ");
}

int minimal = workArray[0];
int row = 0;
for (int i =1; i<workArray.Length; i++)
{
    if(workArray[i]<minimal) 
    {
        minimal = workArray[i];
        row = i+1;
    }
}

Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {row} строка");