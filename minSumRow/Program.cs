int [,] initArr (int m, int n) // инициализация двумерного массива 
{
    int [,] array = new int [m, n];

    Random rand = new Random();

    for (int i = 0 ; i < m ; i++)
    {
        for (int j = 0 ; j < n ; j++)
        {
            array[i,j] = rand.Next(1, 10);
        }
    }
    return array;
}

void printArr(int[,] array, int m, int n) // вывод в консоль массива
{
    for (int i = 0 ; i < m ; i++)
    {
        for (int j = 0 ; j < n ; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int searchMinRow(int[,] array, int m, int n)
{
    int row=0;
    int sum = 1000000;
    for (int i = 0 ; i < m ; i++)
    {
        int sumTemp = 0;
        for (int j = 0 ; j < n ; j++)
        {
            sumTemp += array[i,j];
        }
        Console.WriteLine($"Sum in row {i} = {sumTemp}");
        if (sumTemp < sum) 
        {
            sum = sumTemp;
            row = i;
        }
    }
    return row;
}

Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] arr = initArr (m,n);

printArr(arr, m , n);

if (m!=n)
{
    Console.Write($"Row with min sum elements {searchMinRow(arr, m, n)}");
}