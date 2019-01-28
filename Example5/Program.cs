using System;            

namespace Example5
{
  class Program
  {
    static void Main(string[] args)
    {
      Random ran = new Random(55);
      int[] ar = new int[19999];
      for (int i = 0; i < ar.Length; i++)
        ar[i] = ran.Next();
      Sorting run = new Sorting(ar);
      View watch = new View();    // Создан объект
      run.onSort += new SortHandler(Display.BarShow);
      run.onSort += new SortHandler(watch.nShow);
      run.Sort();
      Console.Write("\n");
      Console.Read();
    }
  }
}
