

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Main();

void Main()
{
    Console.Write("Укажите позицию элемента массива Х: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Укажите позицию элемента массива Y: ");
    int y = int.Parse(Console.ReadLine());

    int[,] array = GetArray(5, 5);
    Print(array);
    PrintResylt(x, y, array);
}
int[,] GetArray(int m, int n)
{
    int[,] resylt = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resylt[i, j] = new Random().Next(1, 30);
        }
    }
    return resylt;
}

void Print(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write("{0,4}", inarray[i, j]);
        }
        Console.WriteLine();
    }

}

void PrintResylt(int x, int y, int[,] array)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        Console.WriteLine(array[x, y]);
    }
    else
    {
        Console.WriteLine("Такого элемента массива нет");
    }
}