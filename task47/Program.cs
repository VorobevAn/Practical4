

// Задача 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Ввудите колличество строк: ");
// double rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Ввудите колличество столбцов: ");
// double columns = int.Parse(Console.ReadLine());

double[,] resylt = GetArray(3, 4);
PrintArray(resylt);

double[,] GetArray(int m, int n)
{
    double[,] resylt = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resylt[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
    return resylt;
}

void PrintArray(double[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", inarray[i, j]);
        }
        Console.WriteLine();
    }

}