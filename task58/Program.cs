// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
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

Console.WriteLine("Колличество строк матрицы:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество столбцов матрицы:");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество столбцов второй матрицы:");
int z = Convert.ToInt32(Console.ReadLine());

int[,] firMatrix = GetMatrix(x,y);
int[,] secMatrix = GetMatrix(y,z);
int[,] mulMatrix = GetMatrix(x,z);    

void MultiMatrix(int[,] firMatrix, int[,] secMatrix, int[,] multiMatrix)
{
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firMatrix.GetLength(1); k++)
            {
                sum += firMatrix[i,k] * secMatrix[k,j];
            }
            mulMatrix[i,j] = sum;
        }
    }
}

MultiMatrix(firMatrix, secMatrix, mulMatrix);
PrintMatrix(firMatrix);
Console.WriteLine();
PrintMatrix(secMatrix);

Console.WriteLine("Результат произведения матриц:");
PrintMatrix(mulMatrix);