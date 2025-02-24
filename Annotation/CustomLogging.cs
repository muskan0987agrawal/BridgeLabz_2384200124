//using System;
//using System.Reflection;
//using System.Reflection.Emit;

//public interface IGreeting
//{
//    void SayHello(string name);
//}

//public class Greeting : IGreeting
//{
//    public void SayHello(string name)
//    {
//        Console.WriteLine($"Hello, {name}!");
//    }
//}

//public class LoggingProxy<T> : DispatchProxy
//{
//    private T _target;

//    public static T Create(T target)
//    {
//        T proxy = DispatchProxy.Create<T, LoggingProxy<T>>();
//        ((LoggingProxy<T>)(object)proxy)._target = target; // Properly assign the target
//        return proxy;
//    }

//    protected override object Invoke(MethodInfo method, object[] args)
//    {
//        Console.WriteLine($"[LOG] Calling method: {method.Name}");
//        return method.Invoke(_target, args);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create an instance of the original class
//        IGreeting greeting = new Greeting();

//        // Create a proxy instance that wraps the original object
//        IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);

//        // Call the method through the proxy
//        proxy.SayHello("Muskan");
//    }
//}
