// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(Double[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().NextDouble()*100;
        }
    }
}
void PrintArray(double[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i, j]+"\t");
        }
         Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Double[,] arr = new Double[line,column];
FillArray(arr);
PrintArray(arr);