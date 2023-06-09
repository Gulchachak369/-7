// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + "\t  ");
    Console.WriteLine();
}

Console.Write("Введите позицию в строке:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в столбце:");
int b = Convert.ToInt32(Console.ReadLine());
if (a >= 0 && a < m && b >= 0 && b < n)
    Console.WriteLine($"Значение элемента массива = {matrix[a, b]}");
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}
