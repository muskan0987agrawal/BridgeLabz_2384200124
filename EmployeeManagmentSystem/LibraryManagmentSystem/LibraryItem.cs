using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;
        //Properties with Validation
        public int ItemId
        {
            get { return itemId; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Item ID must be positive!");
                    Environment.Exit(0);
                }
                itemId = value;
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine(" Title cannot be empty!");
                    Environment.Exit(0);
                }
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine(" Author name cannot be empty!");
                    Environment.Exit(0);
                }
                author = value;
            }
        }
        //Abstract Method: Loan Duration (Subclasses Implement)
        public abstract int GetLoanDuration();

        //Concrete Method: Display Common Details
        public void GetItemDetails()
        {
            Console.WriteLine($" Item ID: {itemId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($" Author: {author}");
            Console.WriteLine($"Loan Duration: {GetLoanDuration()} days");
        }
    }
}
