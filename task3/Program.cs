void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

int[,] matrix = new int [3,4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for (int i = 0; i < 4; i++)             
{
    float mean = 0;
    for (int j = 0; j < 3; j++)
    {
       mean += matrix[j,i];
    }
    Console.WriteLine("Среднее арифметическое " + (i+1) + "-го столбца равно " + Convert.ToSingle(Math.Round(mean/3,2)));
}
