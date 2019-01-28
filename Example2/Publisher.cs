using System;                

namespace Example2
{
  public delegate void EventHappened(); // событийный делегат

  public class Publisher
  { // класс-источник
    public event EventHappened somethingHappened; // событие

    public void fireEvent()
    {
      Console.WriteLine("Fire somethingHappened!!!");
      // запуск события!!!
    }
  }

  // класс-подписчик на somethingHappened
  public class SomethingHappenedSubscriber
  {
    public void SomethingHappenedHandler()
    {
      // код обработки события
      Console.WriteLine("Subscriber has handled an event!");
    }
  }

}
