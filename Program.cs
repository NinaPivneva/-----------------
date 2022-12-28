
// String[,] table = new string[2,5];
// // string.Empty по умолчанию инициализация
// // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// table[1, 2] = "слово";

// //print
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     { 
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// } 
//**************************************************************************************
// аналогично с матрицей (числами)

// int[,] matrix = new int[3,4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();    
// }

// схема вывода в красивую табличку:
//Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();  

// 0 0 0 0 
// 0 0 0 0
// 0 0 0 0

//****************************************************************************
//метод, печатающий двумерную матрицу 
// int[,] matrix = new int[3,4];

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();    
//     }

// }
// заполнить матрицу числами - метод:

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10);
//         }
//     }      
// }

// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);


//*****************************************************************************************
// РЕКУРСИЯ 
//***************************************************************************************
// Вычисление факториала
// Double Factorial(Double n)
// {
//     //по определению факториала мы должны остановиться на единице
//     // 1! = 1
//     // 0! =1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (Double i = 1; i < 40; i++)
// {
    
// Console.WriteLine($"{i}! = {Factorial(i)}");
// }
// Тип данных Double в отличие от int позволяет хранить более длинные числа



//**************************************************************************************

// Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) f(n-1) +f(n-2)

// Double Fibo(Double n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibo(n-1) + Fibo(n-2);
// }
// for (Double i = 1; i < 40; i++)
// {
    
// Console.WriteLine($"f{i} = {Fibo(i)}");
// }