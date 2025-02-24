/*using System;
using System.Reflection;

namespace ReflectionDemo
{
    internal class MethodOverriding
    {
        //Make a base class {Animal}
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal Sound");
            }
        }

        //subclass{dog}
        class Dog: Animal
        {
            public override void MakeSound(){
                Console.WriteLine("Dogs barks");
            }
        }

        class Program1
        {
            public static void Main(string[] args)
            {
                // instance of Dog class
                Animal dog = new Dog();

                //Get the type of the object
                Type type = dog.GetType();

                //Get the MethodInfo for MakeSound()
                MethodInfo method = type.GetMethod("MakeSound");
                if (method != null)
                {
                    //Invoke Method dynamically using reflection
                    method.Invoke(dog, null);
                }
                else
                {
                    Console.WriteLine("Method not found");
                }
            }

        }
    }
}
*/