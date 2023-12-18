//string[,] table = new string[2, 5];
//table[0, 0] table[0,1] table[0, 2] table[0, 3]
//table[1, 0] table[1,1] table[1, 2] table[1, 3]

//table[1, 2] = "слово";
//for (int rows = 0; rows < 2; rows++)
//{
//    for (int colums = 0; colums < 5; colums++)
//    {
//        Console.WriteLine($"{table[rows, colims]}");
//    }
//}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10); //[1; 10)
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

int f(int n)
{
    if(n == 1 || n == 2) return 1;
    else return f(n-1) + f(n-2);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(f(i));
}