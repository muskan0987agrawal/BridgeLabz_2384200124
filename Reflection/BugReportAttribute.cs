//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReflectionDemo
//{
//    //Define a Repeatable Attribute
//    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
//    internal class BugReportAttribute: Attribute
//    {
//        public string Description { get; }

//        public BugReportAttribute(string description)
//        {
//            Description = description;
//        }
//    }

//    internal class BugTracker
//    {
//        [BugReport("Fixes NullReferenceException")]
//        [BugReport("Handles edge cases for empty input")]
//        public void FixBug()
//        {
//            Console.WriteLine("Bug fixed!");
//        }
//    }

//    class Program5
//    {
//        static void Main()
//        {
//            Type type = typeof(BugTracker);
//            MethodInfo method = type.GetMethod("FixBug");

//            //Get all BugReport attributes applied to the method
//            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);

//            Console.WriteLine($"Bug Reports for {method.Name}:");
//            foreach (BugReportAttribute bug in attributes)
//            {
//                Console.WriteLine($"- {bug.Description}");
//            }

//            // Create an instance of BugTracker and invoke the method
//            BugTracker tracker = new BugTracker();
//            method.Invoke(tracker, null);  // This will call FixBug() and print "Bug fixed!"
//        }
//    }


//}
