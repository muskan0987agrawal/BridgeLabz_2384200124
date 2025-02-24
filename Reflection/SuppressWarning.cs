//using System;
//using System.Collections;

//namespace ReflectionDemo
//{
//    internal class SuppressWarning
//    {
//        static void Main()
//        {
//            // Suppress specific compiler warnings
//            #pragma warning disable CS8619, CS8602

//            // Create an ArrayList without generics
//            ArrayList list = new ArrayList();
//            list.Add("35");
//            list.Add("Bonjour");
//            list.Add(4.32);

//            // Access and print elements
//            foreach (var item in list) 
//            {
//                Console.WriteLine(item);
//            }

//            // Enable warnings again
//           #pragma warning restore CS8619, CS8602

//        }


//    }
//}
