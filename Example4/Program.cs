using System;                 

namespace Example4
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Описать класс, содержащий статические методы работы с двумерным целочисленным массивом.
         В классе описать метод построчной печати элементов двумерного массива (по пять элементов в строке). 
         Перевод строки организовать при помощи событий.
      */

      int[,] arr = new int[15, 15];
      Random rnd = new Random();
      for (int i = 0; i <= arr.GetUpperBound(0); i++)
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
          arr[i, j] = rnd.Next(100);
      // в качестве обработчика - лямбда-выражение
      Methods.lineComplete += () => { Console.WriteLine(); };
      Methods.ArrayPrint(arr);
      Console.Read();
    }
  }
}
