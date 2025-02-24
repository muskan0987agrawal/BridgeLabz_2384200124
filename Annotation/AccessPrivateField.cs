//using System;
//using System.Reflection;

//namespace Annotation
//{
//    internal class Person
//    {
//        private int age= 18;
//    }
//    internal class AccessPrivateField
//    {
//        static void Main()
//        {
//            //instance of Person
//            Person person = new Person();
//            Type type = person.GetType();
//            Console.WriteLine(type);

//            //Access private field
//            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

//            //Get field Value
//            Console.WriteLine("Old Value: "+field.GetValue(person));

//            //Modify field Value
//            field.SetValue(person, 20);
//            Console.WriteLine("New Value: " + field.GetValue(person));
//        }
//    }
//}
