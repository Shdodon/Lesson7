// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> по такому индексу нет элемента.
int line = InputNumbers("Введите число строк: ");
int column = InputNumbers("Введите число столбцов: ");
int[,] arrays = ArrayGenerat(line, column);
PrintArray(arrays);

int index1 = InputNumbers("Введите индекс строки: "); // 0 1 2 ...
int index2 = InputNumbers("Введите индекс столбцов: "); // 0 1 2 ...
Console.WriteLine();
FindIndex(arrays, index1, index2);


int InputNumbers(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] ArrayGenerat(int n, int m)
{
    int[,] getArray = new int[n, m];
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
            getArray[i, j] = new Random().Next(0, 10);
        }
    }
    return getArray;
}

void PrintArray(int[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for (int j = 0; j < outArray.GetLength(1); j++)
        {
            Console.Write($"{outArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindIndex(int[,] findArray, int index1, int index2)
{
    int find = -1;
    for (int i = 0; i < findArray.GetLength(0); i++)
    {
        for (int j = 0; j < findArray.GetLength(1); j++)
        {
            if (i == index1 && j == index2)
            {
                //Console.WriteLine($"{findArray[index1, index2]}"); // проверка
                find = findArray[i, j];
            }
        }
    }
    if (find == -1)
    {
        Console.WriteLine("По такому индексу нет элемента");
    }
    else
    {
        Console.WriteLine($"{find}");
    }

}