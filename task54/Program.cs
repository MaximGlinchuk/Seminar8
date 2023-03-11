// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows,cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i,j] = new Random().Next(1,11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Здайте размер массива");

Console.WriteLine("Колличество строк:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(m,n);
PrintMatrix(resultMatrix);

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < resultMatrix.GetLength(1) - 1; k++)
        {
            if (resultMatrix[i, k] < resultMatrix[i, k + 1])
            {
                int temp = resultMatrix[i, k + 1];
                resultMatrix[i, k + 1] = resultMatrix[i, k];
                resultMatrix[i, k] = temp;
            }
        }
    }
}
Console.WriteLine("Отсортированный массив");
PrintMatrix(resultMatrix);



