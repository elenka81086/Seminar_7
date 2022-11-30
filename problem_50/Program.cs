/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в
 двумерном массиве, и возвращает значение этого элемента или же указание, что 
такого элемента нет.*/

int[,] generate2DArray(int lengthRow, int LengthCol, int deviation)
{
    int[,] array = new int[lengthRow,LengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < LengthCol; j++)
        {
            array[i,j] = new Random().Next(-deviation,deviation +1);
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
        printColor(i + "\t",ConsoleColor.DarkCyan);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i+"\t",ConsoleColor.DarkCyan);
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс числа");
int index = Convert.ToInt32(Console.ReadLine());
int[,] newArray = generate2DArray(a, b, 9);
print2DArray(newArray);

int elementInTheArray = a * b - 1;
if (index <= elementInTheArray)

{
   int i = index / b;
   int j = index % b;
   int number = newArray[i, j];
   Console.WriteLine($"Значение под индексом {index} = {number}");
}
else
{
    Console.WriteLine("В массиве нет данного значения");
}
