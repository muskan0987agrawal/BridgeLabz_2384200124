using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

// Logging Proxy using DispatchProxy
public class LoggingProxy<T> : DispatchProxy where T : class
{
    private T _target;

    // Factory method to create proxy instance
    public static T Create(T target)
    {
        if (target == null)
            throw new ArgumentNullException(nameof(target));

        // Create a proxy instance
        LoggingProxy<T> proxy = DispatchProxy.Create<T, LoggingProxy<T>>();
        proxy._target = target; // Properly assign the target
        return (T)(object)proxy;
    }

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine($"[LOG] Calling method: {method.Name}");

        // Ensure target is not null before invoking
        return method.Invoke(_target, args);
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the original class
        IGreeting greeting = new Greeting();

        // Create a proxy instance that wraps the original object
        IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);

        // Call the method through the proxy
        proxy.SayHello("Muskan");
    }
}
