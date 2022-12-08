Console.Clear();

int a = InputNumbers("Введите a: ");
int b = InputNumbers("Введите b: ");
int range = InputNumbers("Введите диапазон до какого числа идет диапазон ");

int[,] array = new int[a, b];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{//1
  for (int i = 0; i < array.GetLength(0); i++)
  {//2
    for (int j = 0; j < array.GetLength(1); j++)
    {//3
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {//4
        if (array[i, k] < array[i, k + 1])
        {//5
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }//5
      }//4
    }//3
  }//2
}//1

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}





void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}







void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}