using System;                       

namespace Example2
{
  class Program
  {
    static void Main(string[] args)
    {
      // объект класса-источника
      Publisher pub = new Publisher();
      // объект класса-подписчика
      SomethingHappenedSubscriber shs =
          new SomethingHappenedSubscriber();
      // добавляем подписчика к событию
      pub.somethingHappened += shs.SomethingHappenedHandler;
      // вызвали метод, запускающий событие
      pub.fireEvent();
      Console.Read();
    }
  }
}
