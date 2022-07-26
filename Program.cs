/*int [,] CreateNewRandom2dArray (int rows, int columns, int minValue, int maxValue)
  {
    int [,] newarray = new int[ rows, columns];
    for ( int i = 0; i< rows; i++)
        for ( int j =0; j< columns; j++)
    newarray[i,j] = new Random().Next(minValue, maxValue);
return newarray;
  }
*/
void Show2dArray ( int [,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for ( int j =0; j < array.GetLength (1); j++)
            Console.Write(array [i,j] + " ");
        Console.WriteLine ();
        }     
 }
 //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
 //по убыванию элементы каждой строки двумерного массива.
 /*int [,]SortArray(int[,]array)
 { 
    for (int i=0; i < array.GetLength(0);i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int j = array.GetLength(1) - 1; j > k; j--)
            {
                if (array[i, j-1]<array[i,j])
                {
                int temp = array[i, j-1];
                array[i, j-1] = array[i,j];
                array [i,j] = temp;
                }
            }
        }
    }   
    Console.WriteLine();
    return array;
 }
Console.Write(" Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input minValue:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input maxValue:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myarray = CreateNewRandom2dArray (m, n, min,max);
Show2dArray(myarray);
Show2dArray(SortArray(myarray));
*/
// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int MinSumRowArray (int[,] array)
  {   
    int sum = 0;
    int [] sums = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
          {
            sum += array[i,j];
          }
    sums[i] = sum;
    sum = 0;
    }
    int imin = 0;
    for (int i = 0; i <sums.Length; i++)
    {  
      if (sums[imin] > sums[i]) 
      {
        imin = i;
      }
    }
    return imin;
  }   
Console.Write(" Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input minValue:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input maxValue:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myarray = CreateNewRandom2dArray (m, n, min,max);
Show2dArray(myarray);
Console.WriteLine(MinSumRowArray(myarray));
*/
//Задача 62.Заполните спирально массив 4 на 4.
// Вариант 1.
/*int [,] CreateSpireArray (int rows, int column)
{
  int[,] array = new int [4,4];
  int n = 1;
  int i; 
  int j;
  int step;
  for (step = 0; step <= 1; step++)
    {
      for (i = 0 + step; i < array.GetLength(0)-3 +step; i++ )
      {
        for (j = 0 + step; j < array.GetLength(1)- step; j++ )

        { 
          array [i,j] = n;
          Console.Write(n +" ");
          n++;
        }
      }
      for ( j = array.GetLength(1) -1 - step; j < array.GetLength(1) - step; j++)
      {
        for ( i = array.GetLength(0) - 3 + step ; i < array.GetLength(0) - step; i++)
        {    
          array [i,j] = n;
          Console.Write(n +" ");
          n++;
        }
      }
      for ( i = array.GetLength(0) - 1 - step ; i < array.GetLength(0) - step; i++) 
      {
        for ( j = array.GetLength(1) -2 - step; j >= array.GetLength(1) - 4 + step; j--)
        {
          array [i,j] = n;
          Console.Write(n +" ");
          n++;
        }
      
      }
      for ( j = 0 ; j >= array.GetLength(1) - 4; j--) 
      {
        for (i = array.GetLength(0) -2- step; i > array.GetLength(0) - 4 + step; i--)
        {
          array [i,j] = n;
          Console.Write(n +" ");
          n++;
        }
      }
    }
  Console.WriteLine();
  return array; 
}
Show2dArray(CreateSpireArray (4,4));
*/
//Вариант 2
/*int [,] CreateSpireArray (int rows, int column)
{
  int[,] array = new int [4,4];
  int n = 1;
  int i; 
  int j;
  i = 0;
  for (j = 0; j < array.GetLength(1); j++ )
  { 
    array [i,j] = n;
    Console.Write(n +" ");
    n++;
  }
  j = array.GetLength(1) - 1;
  for (i = 1; i < array.GetLength(0); i++)
  {    
    array [i,j] = n;
    Console.Write(n +" ");
    n++;
  }
  i = array.GetLength (0) - 1;    
  for (j = array.GetLength(1)-2; j >= 1; j--)
  {
    array [i,j] = n;
    Console.Write(n +" ");
    n++;
  }
  j = 0;   
  for ( i = array.GetLength (0) - 1; i >= 1; i--)
  { 
    array [i,j] = n;
    Console.Write(n +" ");
    n++;
  }
  i = array.GetLength (0) - 3;    
  for (j = array.GetLength(1)-3; j < array.GetLength(1) - 1; j++)
  {
    array [i,j] = n;
    Console.Write(n +" ");
    n++;
  }
  j = array.GetLength(1) - 2;    
  i = array.GetLength(0)-2; 
  array [i,j] = n;
  Console.Write(n +" ");
  n++;
  j = array.GetLength(1) - 3;    
  i = array.GetLength(0) - 2 ; 
  array [i,j] = n;
  Console.Write(n +" ");
  n++;
  Console.WriteLine ();
  return array;
}
Show2dArray(CreateSpireArray (4,4));
*/








