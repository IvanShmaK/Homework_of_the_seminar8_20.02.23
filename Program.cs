/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/*
int[,] Create2DArray(int row, int column, int minVal, int maxVal)
{
    int[,] createdArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createdArray[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return createdArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/
/*
int[,] ElementsDecrease(int[,] array) //метод, который сравнивает два рядом стоящих в строке элемента и меняет их местами, если правый больше левого
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp;
            if (array[i, j + 1] > array[i, j])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }
    return array;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columnss: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

if (userRows > 0 && userColumns > 0) //проверка на правильность ввода чисел
{
    int[,] created2dArray = Create2DArray(userRows, userColumns, userMin, userMax);
    Show2DArray(created2dArray);

    for (int i = 1; i < userColumns; i++) // цикл, который за счет перезаписи массива перетаскивает наибольший элемент в строке в первый столбец, 
    {                                     // и попутно упорядочивает элементы в строке в порядке убывания
        ElementsDecrease(created2dArray);
    }
    Show2DArray(created2dArray);
}
else
    Console.Write("The count of rows and columns must be > 0!");
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
/*
void MinSumElementsAtRow(int[,] array, int row, int column)
{
    int[] tempArray = new int[row];// создаем одномерный массив, элементы которого будут суммами чисел в cтроках двумерного массива
    int a = 0;                     // а - индексы одномерного массива
    for (int i = 0; i < row; i++)  // цикл по формированию одномерного массива
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            sum = sum + array[i, j];
        }
        tempArray[a] = sum;
        a++;
    }
                                   // номером строки с наименьшей суммой элементов будет индекс наименьшего числа в одномерном массиве
    int minElement = tempArray[0]; // первый элемент принимаем за минимальный
    int result = 0;                // result - индекс наименьшего числа
    a = 1;                         // сбрасывам счетчик (он же индекс) до 1
    while (a < row)
    {
        if (tempArray[a] < minElement)
        {
            minElement = tempArray[a];
            result = a;
        }
        a++;
    }
    Console.Write($"The number of the row with the smallest sum of elements is: {result + 1}");//прибавляем 1, чтобы пользователю был более понятен номер строки
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columnss: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

if (userRows > 0 && userColumns > 0)
{
    int[,] created2dArray = Create2DArray(userRows, userColumns, userMin, userMax);
    Show2DArray(created2dArray);
    MinSumElementsAtRow(created2dArray, userRows, userColumns);
}    
else
    Console.Write("The count of rows and columns must be > 0!");
*/

/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 9, 9, 0,
2, 8, 0, 9
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз */
/*
void Number(int[,] array, int num) // метод по нахождению количества раз встречаемости определенной цифры в массиве
{                                  // num - искомая цифра, count - счетчик
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) count++;
        }
    }
    if (count == 1) Console.WriteLine($"The element {num} occurs in the array {count} time");
    if (count > 1) Console.WriteLine($"The element {num} occurs in the array {count} times");//условие для орфографической правильности time/times
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columnss: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

if (userRows > 0 && userColumns > 0)
{
    int[,] created2dArray = Create2DArray(userRows, userColumns, userMin, userMax);
    Show2DArray(created2dArray);
    int figure = userMin;
    while (figure < userMax + 1)//цикл, который перебирает все элементы массива. Пределы перебора заданы пользователем (userMin и userMax)
    {
        Number(created2dArray, figure);
        figure++;
    }
}
else
    Console.Write("The count of rows and columns must be > 0!");
*/

/*Задача 58:(дополнительная) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*
int [,] ProductOfMatrices(int[,] array1, int [,] array2, int row1, int column2, int column1)//метод нахождения результирующей матрицы
{
    int [,] resArray = new int [row1, column2];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            resArray [i, j] = 0;//каждый новый элемент обнуляется, чтобы не складывался с предыдущими
            for (int ind = 0; ind < column1; ind++)// ind - индекс, который будет меняться в процессе умножения
            {
                resArray [i, j] += array1 [i, ind] * array2 [ind, j];
            }
        }
    }
    return resArray;
}

Console.Write("Input count of rows in the firs matrix: ");
int userRows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columnss in the firs matrix: ");
int userColumns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value in the firs matrix: ");
int userMin1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value in the firs matrix: ");
int userMax1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of rows in the second matrix: ");
int userRows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columnss in the second matrix: ");
int userColumns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value in the second matrix: ");
int userMin2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal value in the second matrix: ");
int userMax2 = Convert.ToInt32(Console.ReadLine());

if (userRows1 > 0 && userColumns1 > 0 && userRows2 > 0 && userColumns2 > 0)//проверка на правильность введения значений пользователем
{
    if (userColumns1 == userRows2)//проверка на возможность умножения двух матриц 
    {
        int[,] created2dArray1 = Create2DArray(userRows1, userColumns1, userMin1, userMax1);
        Show2DArray(created2dArray1);
        int[,] created2dArray2 = Create2DArray(userRows2, userColumns2, userMin2, userMax2);
        Show2DArray(created2dArray2);
        int[,] resultArray = ProductOfMatrices(created2dArray1, created2dArray2, userRows1, userColumns2, userColumns1);
        Show2DArray(resultArray);
    }
    else Console.Write("The number of columns of the first matrix must match the number of rows of the second matrix!");
}
else
    Console.Write("The count of rows and columns must be > 0!");
*/

/*Задача 60.(дополнительная) Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] Create3DArray(int row, int column, int depth)
{
    int[,,] array = new int[row, column, depth];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $"({i},{j},{k})" + " ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columnss: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of depth: ");
int userDepth = Convert.ToInt32(Console.ReadLine());

int[,,] created3dArray = Create3DArray(userRows, userColumns, userDepth);
Show3DArray(created3dArray);   //создать и вывести массив получилось, а вот сделать числа неповторяющимися - нет(((

/*Задача 62. (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/   //эту задачу я не решил. Решение взято из интернета. Честно говоря, не особо понимаю даже, что тут написано.
/*              //Кстати, у решения есть изъян. Если брать нечетный размер массива, в центре будет 00
void SpiralArray(int[,] array, int n)
{
    int i = 0; 
    int j = 0;
    int value = 1;
    for (int e = 0; e < n * n ; e++)
    {
        int k = 0;
        do 
        { 
            array[i, j++] = value++; 
        } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write("0" + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input the number of rows in the square array: ");
int length = Convert.ToInt32(Console.ReadLine());

int [,] squareArray = new int [length, length];

SpiralArray(squareArray, length);
Show2DArray(squareArray);
*/