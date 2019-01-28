using System;             

namespace Example1
{
  // событийный делегат
  class Program
  {
    static event Del Ev; // событие

    // набор обработчиков
    static void f1() { Console.WriteLine("f1"); }
    static void f2() { Console.WriteLine("f2"); }


    static void Main(string[] args)
    {
      Ev += f1; // добавление обработчика
      Ev += f2; // добавление обработчика
      // добавление обработчика
      // запуск события
    }
  }
}
