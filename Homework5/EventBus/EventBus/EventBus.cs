using System;
using System.Collections.Generic;

namespace EventBus;

public class EventBus
{
    private readonly List<IPublisher> _publishers;

    public EventBus()
    {
        _publishers = new List<IPublisher>();
    }

    public void AddPublisher(IPublisher publisher)
    {
        _publishers.Add(publisher);
    }

    public void RemovePublisher(IPublisher publisher)
    {
        _publishers.Remove(publisher);
    }

    public void Subscribe(Publisher publisher, ISubscriber subscriber)
    {
        publisher.OnPost += subscriber.OnEvent;
    }
    
    public void Unsubscribe(Publisher publisher, ISubscriber subscriber)
    {
        publisher.OnPost -= subscriber.OnEvent;
    }
}