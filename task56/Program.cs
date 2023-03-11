// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int m = Convert.ToInt32(Console.ReadLine());


int[,] matrix = GetMatrix(m,m);
PrintMatrix(matrix);

int SumRows(int[,] matrix, int i)
{
  int sumRows = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumRows += matrix[i,j];
  }
  return sumRows;
}

int minSumRows = 0;
int sumRows = SumRows(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSum = SumRows(matrix, i);
  if (sumRows > tempSum)
  {
    sumRows = tempSum;
    minSumRows = i;
  }
}

Console.WriteLine($"Строка {minSumRows+1} является наименьшей и имеет сумму {sumRows}");