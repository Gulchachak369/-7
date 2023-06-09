// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void FillMatrixWhithRandomNumbers(int[,] matrix) // метод для заполнения массива
{
    Random rnd = new Random(); // 
    for (int i = 0; i < matrix.GetLength(0); i++) //GetLength(0)для двумерного массива определяет количество строк 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) сколько будет столбцов
        {
            matrix[i, j] = rnd.Next(0, 11); // генерация рандомных чисел от 0 до 10
        }
    }
}

void PrintMatrix(int[,] matrix) // метод для печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t"); // \t это табуляция \n это отступ вниз
        }
        System.Console.WriteLine(); // делаем пустую строку
    }
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввели количество строк
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввели количество столбцов
int[,] matrix = new int[m, n]; // создается массив

FillMatrixWhithRandomNumbers(matrix); // вызов метода
PrintMatrix(matrix); // печатаем массив