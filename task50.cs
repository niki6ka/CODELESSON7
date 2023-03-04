// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

int r = new Random().Next(0, 10);
int c = new Random().Next(0, 10);
int[,] TwoDimArray = new int[r, c];
void FillTwoDimArray(int[,] TwoDimArray)
{
    for (int i = 0; i < TwoDimArray.GetLongLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < TwoDimArray.GetLength(1); j++)
        {
            TwoDimArray[i, j] = new Random().Next(0, 10);
            Console.Write(TwoDimArray[i, j] + " ");
           
        }
         }
}

FillTwoDimArray(TwoDimArray);
Console.WriteLine();
Console.WriteLine("Please enter number of array rows (from 0):");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of array columns (from 0):");
int col = Convert.ToInt32(Console.ReadLine());
if (row > r || col > c) 
{Console.WriteLine("There is no such element in the matrix!!!");}
Console.WriteLine("Array element value with position:" + (row) + " " + (col) + " - " + TwoDimArray[row, col]);