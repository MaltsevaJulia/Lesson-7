// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int row = DataEntry("Номер строки ");
int col = DataEntry("Номер столбца ");
if(row<=sizem && col<=sizen)
{
    System.Console.WriteLine(numbers[row-1, col-1]);
}
else
{
    System.Console.WriteLine("Такого числа в массиве нет");
}

