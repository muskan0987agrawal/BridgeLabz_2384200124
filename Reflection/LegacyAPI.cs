//using System;


//namespace ReflectionDemo
//{
//    internal class LegacyAPI
//    {
//        // Marking the old method as obsolete
//        [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.", true)]
//        public void OldFeature()
//        {
//            Console.WriteLine("This is the Old Method");
//        }

//        // New recommended method
//        public void NewFeature()
//        {
//            Console.WriteLine("This is the New Method");
//        }
//    }

//    class Program2
//    {
//        public static void Main()
//        {
//            LegacyAPI legacyAPI = new LegacyAPI();
//            // Calling the old method (should show a warning) , if i dont use the true
//            // legacyAPI.OldFeature();
//            // Calling the new method (no warning)
//            legacyAPI.NewFeature();
//        }
//    }
//}
