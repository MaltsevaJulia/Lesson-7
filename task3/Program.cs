// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array, int m, int n)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            int num = new Random().Next(1, 100);
            array[i, j] = num;
        }
    }
}

int sizem = DataEntry("Введите m размер массива ");
int sizen = DataEntry("Введите n размер массива ");
int[,] numbers = new int[sizem, sizen];

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

System.Console.Write("Среднее арифметическое каждого столбца: ");

for(int j=0; j<sizen; j++)
{
    double sum = 0;
    for(int i=0; i<sizem; i++)
    {
        sum = sum+numbers[i, j];
    }
    double avg = sum/sizem;
    System.Console.Write(avg);
    System.Console.Write(" ");
}


