/*using System;

namespace Inheritance
{
    internal class Person
    {
        protected string name;
        protected string id;

        public void SetPersonDetails(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public virtual void DisplayPersonInfo()
        {
            Console.WriteLine($"Class: Person \nName: {name} \nId: {id}");
        }
    }

    interface IWorker
    {
        void PerformDuties();
    }

    internal class Chef : Person, IWorker
    {
        private string speciality;

        public void SetChefDetails(string name, string id, string speciality)
        {
            base.SetPersonDetails(name, id);
            this.speciality = speciality;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{name} is cooking special {speciality} dishes.");
        }

        public void DisplayChefInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Role: Chef \nSpeciality: {speciality}");
        }
    }

    internal class Waiter : Person, IWorker
    {
        private string assignedSection;

        public void SetWaiterDetails(string name, string id, string section)
        {
            base.SetPersonDetails(name, id);
            this.assignedSection = section;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{name} is serving customers in {assignedSection} section.");
        }

        public void DisplayWaiterInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Role: Waiter \nAssigned Section: {assignedSection}");
        }
    }

    internal class Program10
    {
        public static void Main()
        {
            // Array to store Worker objects
            IWorker[] worker = new IWorker[2];

            // Creating Chef
            worker[0] = new Chef();
            ((Chef)worker[0]).SetChefDetails("John", "101", "Italian Cuisine");

            // Creating Waiter
            worker[1] = new Waiter();
            ((Waiter)worker[1]).SetWaiterDetails("ZXCV", "201", "Outdoor Dining");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. View Chef Details");
                Console.WriteLine("2. View Waiter Details");
                Console.WriteLine("3. Perform Duties");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nChef Details:");
                        ((Chef)worker[0]).DisplayChefInfo();
                        Console.WriteLine("----------------------");
                        break;
                    case 2:
                        Console.WriteLine("\nWaiter Details:");
                        ((Waiter)worker[1]).DisplayWaiterInfo();
                        Console.WriteLine("----------------------");
                        break;
                    case 3:
                        Console.WriteLine("\nPerforming Duties:");
                        foreach (IWorker w in worker)
                        {
                            w.PerformDuties();
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
   
}
*/