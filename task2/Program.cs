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
Console.Write("Введите количество строк: ");
int a = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите количество столбцов: ");
int b = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine();

int[,] matrix = new int [a,b];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

Console.Write("Введите столбец: ");
int n = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите строку: ");
int m = (Convert.ToInt32(Console.ReadLine()));

if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1))   
{
    Console.WriteLine($"Элемент массива [{m-1},{n-1}] = {matrix[m-1,n-1]}");
}
else
{
    Console.WriteLine($"Такой позиции [{m},{n}] в массиве не существует!");
}