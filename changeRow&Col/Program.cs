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

void changeRolCol(int[,] array, int m, int n) // замена строки и столбец
{
    for (int i = 0; i < m ; i++)
    {
        for (int j = i ; j < n ; j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        } 
    }
}

Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] arr = initArr (m,n);
printArr(arr, m, n);

Console.WriteLine("----------------------");

if (m == n) 
{
    changeRolCol(arr, m , n);
    printArr(arr, m, n);
}
else Console.WriteLine("матрица не квадратная");
