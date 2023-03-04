// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Please enter number of array rows (from 0):");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of array columns (from 0):");
int col = Convert.ToInt32(Console.ReadLine());

int[,] TwoDimArray = new int[row, col];
void FillTwoDimArray(int[,] TwoDimArray)
{
    for (int i = 0; i < TwoDimArray.GetLongLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < TwoDimArray.GetLength(1); j++)
        {
            TwoDimArray[i, j] = new Random().Next(0, 10);
            Console.Write(TwoDimArray[i, j] + "  ");
           
        }
         }
}
double average = 0;
void AverageEachColumn(int[,] TwoDimArray)
{
for (int j = 0; j < TwoDimArray.GetLongLength(1); j++)
    {
        Console.WriteLine();
        for (int i = 0; i < TwoDimArray.GetLength(0); i++)
        {
            average = average + TwoDimArray[i, j];
         }
         Console.Write("Average in " + j + " column = " + average/row);
         average = 0;
         }
            

}

FillTwoDimArray(TwoDimArray);
Console.WriteLine();
AverageEachColumn(TwoDimArray);


