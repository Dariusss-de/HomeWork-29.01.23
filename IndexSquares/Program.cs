// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


void FillArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}
void PrintArray(int[,] array)
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

void SquaresIndexArray (int[,] array)
{
     for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            if(i%2==0 && j%2==0) 
            {
            array[i,j] = array[i,j]*array[i,j];
            }
            Console.Write(array[i, j]+"\t");
        }
         Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
try
{
    if(line<=0 || column<=0) 
    {
    throw new Exception("wrong line or colum");
    }
}
catch
{
     Console.Write("Введите количество строк: ");
    line = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    column = int.Parse(Console.ReadLine());
}

int[,] arr = new int[line,column];
FillArray(arr);
PrintArray(arr);
SquaresIndexArray (arr);

