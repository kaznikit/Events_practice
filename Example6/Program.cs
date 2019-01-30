using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
  class Program
  {
    public delegate void StateChanged();

    public interface IChannel
    {
      event StateChanged StateChangedHandler;
      void DoSomething();
    }

    public class SomeChannel : IChannel
    {
      public event StateChanged StateChangedHandler;
      public void DoSomething()
      {
        throw new NotImplementedException();
      }
    }

    static void Main(string[] args)
    {
    }

    public class ChannelsViewModel
    {
      private readonly List<IChannel> m_channels = new List<IChannel>();

      public void Add(IChannel _channel)
      {
        if (_channel == null)
          throw new ArgumentNullException(nameof(_channel));

        _channel.StateChangedHandler += ChannelOnStateChangedHandler;

        m_channels.Add(_channel);
      }

      public void Clear()
      {
        foreach(var channel in m_channels)
        {
          //необходимо отписываться от событий, иначе объект не будет удален из памяти 
          channel.StateChangedHandler -= ChannelOnStateChangedHandler;
        }
        m_channels.Clear();
      }

      private void ChannelOnStateChangedHandler()
      {
        throw new NotImplementedException();
      }

      public void Remove(IChannel _channel)
      {
        _channel.StateChangedHandler -= ChannelOnStateChangedHandler;
        m_channels.Remove(_channel);
      }
    }
  }
}
