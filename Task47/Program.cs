void FillArray(double[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
        for (int j =0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10,10) + new Random().NextDouble();
}

void PrdoubleArray(double[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количетсво строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m,n];
FillArray(array);
PrdoubleArray(array);
