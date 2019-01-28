using System; 

namespace Example4
{
  public delegate void LineCompleteEvent();

  public class Methods
  {
    // статическое событие
    public static event LineCompleteEvent lineComplete;

    public static void ArrayPrint(int[,] arr)
    {
      for (int i = 0; i <= arr.GetUpperBound(0); i++)
      {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
          Console.Write(arr[i, j] + " ");
        lineComplete(); // событие!!
      }
    }
  }       
}
