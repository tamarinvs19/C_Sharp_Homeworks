using System;

namespace EventBus;

public interface IPublisher
{
    public string getName();
    public event EventHandler<Post> OnPost;
    public void Post();
}

public class Publisher
{
    public readonly string Name;

    public Publisher(string name)
    {
        Name = name;
    }

    public event EventHandler<Post> OnPost = delegate {  };

    public void Post(string title)
    {
        Console.WriteLine($"Create new post from {Name} at {DateTime.Now}!");
        OnPost.Invoke(this, new Post(Name, title));
    }
}