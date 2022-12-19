Console.WriteLine("Введите резмер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int s = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
findnum(m, n);


void findnum (int m, int n)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int count = 0;
for (int e = 0; e <  array.GetLength(0); e++)
{
    for (int r = 0; r < array.GetLength(1); r++)
    {
        if (array[e, r] == s) {
            Console.WriteLine($"Искомое число находится в координате {e} и {r}");
            count++;
        }
        // else Console.WriteLine($"Искомого числа нет!");
    }
    Console.WriteLine();
}

if(count<= 0) Console.WriteLine($"Искомого числа нет!");
}
