/*Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.*/


int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow,lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i,j] = new Random().Next(-deviation,deviation);
        }
    }
    return array;
}
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

void print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t",ConsoleColor.DarkCyan + 1);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i+"\t",ConsoleColor.DarkCyan);
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = generate2DArray(a,b,100);
print2DArray(array);
Console.WriteLine();

for (int j = 0; j < b; j++)
{
    double sum = 0;
    for (int i = 0; i < a; i++)
    {
        sum = (sum + array[i, j]);
    }
    sum = sum / b;
    Console.WriteLine($" Средним арифметическим для столбца {j} является {Math.Round(sum, 2)} ");
}