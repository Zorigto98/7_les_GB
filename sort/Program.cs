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

void sortArr (int[,] array, int m, int n) // сортировка перемещением
{
    for (int i = 0 ; i < m ; i++)
    {
        int left = 0;
        int right = n-1;
        while (left <= right)
        {
            for (int j = right; j > left; j--)
            {
                if (array[i,j-1] < array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j-1];
                    array[i,j-1] = temp;
                }
            }
            left++;

            for (int j = left; j < right; j++)
            {
                if (array[i,j] < array[i,j+1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
            right--;
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
sortArr(arr, m , n);
printArr(arr, m, n);