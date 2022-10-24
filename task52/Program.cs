

// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Приветсвую!!! Хотите ли сами задать размеры массива Y/N: ");
string answer = Console.ReadLine()!;
int[,] resylt = Array(answer);
Print(resylt);
Console.WriteLine("Среднеарефметическое каждого столбца: ");
Arithmetic(resylt);
int[,] Array(string ans)
{
    int[,] arr = GetArray(4, 4);
    while(ans == "Y")
    {        
        Console.WriteLine("Введите колличество строк: ");
        int rows = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите колличество столбцов: ");
        int columns = int.Parse(Console.ReadLine()!);
        arr =  GetArray(rows, columns);
        break;
    }
        
   return arr;
}


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write("{0,6}", inarray[i, j]);
        }
        Console.WriteLine();
    }
}

void Arithmetic(int[,] resylt)
{

    for (int j = 0; j < resylt.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < resylt.GetLength(0); i++)
        {
            sum += resylt[i, j];
        }
        Console.Write("{0,6:F1}", sum / resylt.Length);

    }

}

