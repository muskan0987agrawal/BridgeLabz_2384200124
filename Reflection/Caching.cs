using System;
using System.Collections.Generic;
using System.Reflection;

// Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method)] // Applied only to methods
internal class CacheResultAttribute : Attribute
{
}

internal class CacheManager
{
    private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

    public static object InvokeWithCache(object obj, string methodName, params object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            throw new InvalidOperationException($"Method '{methodName}' not found.");
        }

        // Check if method has the CacheResult attribute
        if (method.GetCustomAttribute(typeof(CacheResultAttribute)) is CacheResultAttribute)
        {
            // Create a unique cache key using method name and parameters
            string key = methodName + string.Join("_", parameters);

            // If result is already cached, return it
            if (Cache.ContainsKey(key))
            {
                Console.WriteLine($"Returning cached result for {methodName}({string.Join(", ", parameters)})");
                return Cache[key];
            }

            // Compute result and store it in the cache
            object result = method.Invoke(obj, parameters);
            Cache[key] = result;
            return result;
        }

        // If the method is not marked with CacheResult, call it normally
        return method.Invoke(obj, parameters);
    }
}

internal class ExpensiveOperations
{
    [CacheResult] // Apply caching to this method
    public int ComputeFactorial(int n)
    {
        Console.WriteLine($"Computing factorial of {n}...");
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        ExpensiveOperations operations = new ExpensiveOperations();

        // First call - should compute and store in cache
        Console.WriteLine(CacheManager.InvokeWithCache(operations, "ComputeFactorial", 5));

        // Second call - should return cached result
        Console.WriteLine(CacheManager.InvokeWithCache(operations, "ComputeFactorial", 5));

        // Different input - should compute again
        Console.WriteLine(CacheManager.InvokeWithCache(operations, "ComputeFactorial", 6));
    }
}
