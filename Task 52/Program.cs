// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillMatrixWhithRandomNumbers(int[,] matrix)  
{ 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            matrix[i, j] = rnd.Next(0, 11); 
        } 
    } 
} 
 
void PrintMatrix(int[,] matrix)  
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            System.Console.Write($"{matrix[i, j]} " + "\t"); 
        } 
        System.Console.WriteLine(); 
    } 
} 
 
double[] Sum(int[,] matrix)  
{ 
    int sum; 
    int rowCount = matrix.GetLength(0); 
    int columnCount = matrix.GetLength(1); 
     
    double[] result = new double[columnCount]; 
 
    for (int i = 0; i < columnCount; i++) 
    { 
        sum = 0; 
        for (int j = 0; j < rowCount; j++) 
        { 
           sum += matrix[j, i]; 
        } 
        result[i] = sum /rowCount; 
    } 
    return result; 
} 
 
System.Console.Write("Введите количество строк массива: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите количество столбцов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[m, n]; // 0 - row, 1 - column 
 
FillMatrixWhithRandomNumbers(matrix); 
PrintMatrix(matrix); 
System.Console.WriteLine("=========results========="); 
System.Console.WriteLine("{0}", string.Join("\t", Sum(matrix)));
