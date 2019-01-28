using System;

namespace Example5
{
  class View
  {    // Обработчик событий в объектах
    public void nShow(long n, int si, int kl)
    {
      Console.Write("\r" + n); // статус сортировки
    }
  }
  class Display
  { // Обработчик событий в этом классе
    static int len = 30;
    static string st = null;

    public static void BarShow(long n, int si, int kl)
    {
      int pos = Math.Abs((int)((double)kl / si * len));
      string s1 = new string('\u258c', pos); //код для вертикального бара
      string s2 = new string('-', len - pos - 1) +
                                 '\u25c4';   // unicode для треугольника;
      st = s1 + '\u258c' + s2; //'\u258c' - код прямоугольника 
      Console.Write("\r\t\t" + st);
    }
  }
}
