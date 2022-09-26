// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[,] array, int m, int n)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            Double num = new Random().NextDouble();
            array[i, j] = Math.Round(num*1000, 2);
        }
    }
}

int sizem = DataEntry("Введите m размер массива ");
int sizen = DataEntry("Введите n размер массива ");
double[,] numbers = new double[sizem, sizen];

FillArray(numbers, sizem, sizen);
for(int i=0; i<sizem; i++)
{
    for(int j=0; j<sizen; j++)
    {
        System.Console.Write(numbers[i, j]);
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}


