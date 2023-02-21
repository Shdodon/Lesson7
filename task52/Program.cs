// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int line = InputIndex("Введите число строк: ");
int column = InputIndex("Введите число столбцов: ");

int[,] testArray = GenArray(line, column); // создадим массив и положим в него сгенерированный)

PrintArrayMult(testArray); // распечатаем новый массив
Console.WriteLine();
ColumAverage(testArray); // печать среднего (если void)
Console.WriteLine();
PrintArray(ColumAverage(testArray));

int InputIndex(string message)
{
    Console.WriteLine(message);
    int indexs = int.Parse(Console.ReadLine());
    return indexs;
}

int[,] GenArray(int lineIndex, int columIndex)
{
    int[,] array = new int[lineIndex, columIndex];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 40);
        }
    }
    return array;
}

void PrintArrayMult(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] ColumAverage(int[,] findArray)
{
    double[] average = new double[findArray.GetLength(1)];
    for (int j = 0; j < findArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < findArray.GetLength(0); i++)
        {
            sum += findArray[i, j];
            // Console.Write($"{sum} "); //просмотр суммы
            //Console.WriteLine($"{average} ");
        }
        average[j] = Math.Round(sum / findArray.GetLength(0), 3);
        //Console.Write($"{average[j]} "); // выдача без метода, если void
    }
    return average;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}