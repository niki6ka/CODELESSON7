// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//////m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.WriteLine("Please enter number of array rows:");
    int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number of array columns:");
    int col = Convert.ToInt32(Console.ReadLine());
double[,] TwoDimArray = new double[row, col];
void FillTwoDimArray(double[,] TwoDimArray)
{
    for (int i = 0; i < TwoDimArray.GetLongLength(0); i++)
        {
            Console.WriteLine();
                for (int j=0; j<TwoDimArray.GetLength(1); j++)
                    {
                        TwoDimArray[i, j] = new Random().NextDouble();
                        Console.Write(TwoDimArray[i, j] + " ");
                    }

        }

}
FillTwoDimArray(TwoDimArray);