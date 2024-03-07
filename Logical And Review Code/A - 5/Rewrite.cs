using System;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new EventPublisher();
            while (true)
            {
                var subscriber = new EventSubscriber(publisher);
                // do something with the publisher and subscriber objects
                // For demonstration purposes, I'll just let the loop run infinitely
            }
        }

        class EventPublisher
        {
            public event EventHandler MyEvent;
            public void RaiseEvent()
            {
                MyEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        class EventSubscriber
        {
            private readonly EventPublisher _publisher;

            public EventSubscriber(EventPublisher publisher)
            {
                _publisher = publisher;
                _publisher.MyEvent += OnMyEvent;
            }

            private void OnMyEvent(object sender, EventArgs e)
            {
                Console.WriteLine("MyEvent raised");
            }

            // Method to unsubscribe from the event when no longer needed
            public void Unsubscribe()
            {
                _publisher.MyEvent -= OnMyEvent;
            }
        }
    }
}
