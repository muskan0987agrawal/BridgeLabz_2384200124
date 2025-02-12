////using System;
////using System.Collections.Generic;


//namespace Program1Student
//{
//    public class InventoryItem
//    {
//        public int ItemID { get; set; }
//        public string ItemName { get; set; }
//        public int Quantity { get; set; }
//        public double Price { get; set; }

//        public InventoryItem(int itemID, string itemName, int quantity, double price)
//        {
//            this.ItemID = itemID;
//            this.ItemName = itemName;
//            this.Quantity = quantity;
//            this.Price = price;
//        }

//        public void ShowItemDetails()
//        {
//            Console.WriteLine($"Item ID: {ItemID}, Name: {ItemName}, Quantity: {Quantity}, Price: {Price}");
//        }
//    }

//    public class Node
//    {
//        public InventoryItem item;
//        public Node next;

//        public Node(InventoryItem item)
//        {
//            this.item = item;
//            this.next = null;
//        }

//    }

//    public class InventoryList
//    {
//        private Node head;
//        private Node tail;

//        public InventoryList()
//        {
//            this.head = null;
//            this.tail = null;
//        }

//        public void AddItemAtBeg(InventoryItem newItem)
//        {
//            Node newNode = new Node(newItem);
//            if (head == null)
//            {
//                head = tail = newNode;
//            }
//            else
//            {
//                newNode.next = head;
//                head = newNode;
//            }
//        }

//        public void AddItemAtEnd(InventoryItem newItem)
//        {
//            Node newNode = new Node(newItem);
//            if (head == null)
//            {
//                head = tail = newNode;
//                return;
//            }
//            else
//            {
//                tail.next = newNode;
//                tail = newNode;
//            }
//        }

//        public void AddInBetween(InventoryItem newItem1, int pos)
//        {
//            Node newNode = new Node(newItem1);
//            if (pos <= 1)
//            {
//                newNode.next = head;
//                head = newNode;
//                return;
//            }

//            int count = 1;
//            Node temp = head;
//            while (count < pos - 1 && temp.next != null)
//            {
//                temp=temp.next;
//                count++;
//            }
//            temp.next = newNode;
//            temp = newNode;
//        }

//        public void RemoveItemById(int itemId)
//        {

//            if (head == null) { Console.WriteLine("Item List is Empty"); return; }
//            if (head.item.ItemID == itemId)
//            {
//                head = head.next;
//                return;
//            }

//            Node temp = head;
//            Node prev = null;
//            while(head.item.ItemID != null && temp != null)
//            {
//                prev = temp;
//                temp = temp.next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine($"{itemId} does not exist in the item List");
//                return;

//            }
//            prev.next = temp.next;
//        }

//        public void DisplayInventory()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Inventory is empty!");
//                return;
//            }

//            Node temp = head;
//            Console.WriteLine("Inventory Items:");
//            while (temp != null)
//            {
//                temp.item.ShowItemDetails();
//                temp = temp.next;
//            }
//        }
//        public void UpdateQuantityById(int id, int quantity)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Inventory is empty!");
//                return;
//            }
          
//            Node temp = head;
//            while(temp != null && temp.item.ItemID != id)
//            {
//                temp = temp.next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine($"{id} item doesn't exist");
//                return;
//            }

//            if (head.item.ItemID == id)
//            {
//                head.item.Quantity = quantity;
//            }
//        }

//        public void SearchById(int id)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Inventory is empty!");
//                return;
//            }
//            Node temp = head;
//            while (temp != null && temp.item.ItemID != id)
//            {
//                temp = temp.next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine($"{id} item doesn't exist in the inventory");
//                return;
//            }

//            if (head.item.ItemID == id)
//            {
//                head.item.ShowItemDetails();
//            }
//        }

//        public void SearchByItemName(string itemName)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Inventory is empty!");
//                return;
//            }
//            Node temp = head;
//            while (temp != null && temp.item.ItemName != itemName)
//            {
//                temp = temp.next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine($"{itemName} item doesn't exist in the inventory");
//                return;
//            }

//            if (head.item.ItemName== itemName)
//            {
//                head.item.ShowItemDetails();
//            }
//        }

//        public void CalculateInventory()
//        {
//            if (head == null)
//            {
//                Console.WriteLine($" item doesn't exist in the inventory");
//                return;
//            }

//            Node temp = head;
//            double total = 0.0 ;
//            while (temp != null)
//            {
//                 total += temp.item.Price * temp.item.Quantity;
//                temp = temp.next;
//            }

//            Console.WriteLine("Total Price: " + total);
//        }

//        public void SortInventory()
//        {
//            if (head == null)
//            {
//                Console.WriteLine($" Sorting doesn't possible in the empty inventory");
//                return;
//            }
//            Node ptr = head;
//            Node cpt ;
//            int temp;
//            while(ptr != null)
//            {
//                cpt = ptr.next; 
//                while(cpt != null)
//                {
//                    if (ptr.item.ItemID > cpt.item.ItemID)
//                    {
//                        temp = ptr.item.ItemID;
//                        ptr.item.ItemID = cpt.item.ItemID;
//                        cpt.item.ItemID = temp;
//                    }
//                    cpt = cpt.next;
//                }
//                ptr = ptr.next;
//            }
//        }
//    }
    

//            internal class Program2
//        {
//            public static void Main()
//            {
//                InventoryList inventory = new InventoryList();

//                while (true)
//                {
//                    // Display the menu options
//                    Console.WriteLine("\n========== Inventory Management System ==========");
//                    Console.WriteLine("1. Add Item at Beginning");
//                    Console.WriteLine("2. Add Item at End");
//                    Console.WriteLine("3. Add Item at Specific Position");
//                    Console.WriteLine("4. Remove Item by ID");
//                    Console.WriteLine("5. Update Quantity by ID");
//                    Console.WriteLine("6. Search Item by ID");
//                    Console.WriteLine("7. Search Item by Name");
//                    Console.WriteLine("8. Display Inventory");
//                    Console.WriteLine("9. Sort Inventory by ID");
//                    Console.WriteLine("10. Calculate Total Inventory Value");
//                    Console.WriteLine("11. Exit");
//                    Console.Write("Enter your choice: ");

//                    string choice = Console.ReadLine(); // Read user input

//                    switch (choice)
//                    {
//                        case "1":
//                            // Add item at the beginning
//                            inventory.AddItemAtBeg(GetInventoryItemFromUser());
//                            Console.WriteLine("Item added at the beginning.");
//                            break;

//                        case "2":
//                            // Add item at the end
//                            inventory.AddItemAtEnd(GetInventoryItemFromUser());
//                            Console.WriteLine("Item added at the end.");
//                            break;

//                        case "3":
//                            // Add item at a specific position
//                            Console.Write("Enter position: ");
//                            if (int.TryParse(Console.ReadLine(), out int pos))
//                            {
//                                inventory.AddInBetween(GetInventoryItemFromUser(), pos);
//                                Console.WriteLine($"Item added at position {pos}.");
//                            }
//                            else
//                            {
//                                Console.WriteLine("Invalid position! Please enter a number.");
//                            }
//                            break;

//                        case "4":
//                            // Remove item by ID
//                            Console.Write("Enter Item ID to remove: ");
//                            if (int.TryParse(Console.ReadLine(), out int id))
//                            {
//                                inventory.RemoveItemById(id);
//                            }
//                            else
//                            {
//                                Console.WriteLine("Invalid ID! Please enter a valid number.");
//                            }
//                            break;

//                        case "5":
//                            // Update item quantity
//                            Console.Write("Enter Item ID to update quantity: ");
//                            if (int.TryParse(Console.ReadLine(), out int updateId))
//                            {
//                                Console.Write("Enter new quantity: ");
//                                if (int.TryParse(Console.ReadLine(), out int quantity))
//                                {
//                                    inventory.UpdateQuantityById(updateId, quantity);
//                                    Console.WriteLine("Quantity updated successfully.");
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Invalid quantity! Please enter a valid number.");
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("Invalid ID! Please enter a valid number.");
//                            }
//                            break;

//                        case "6":
//                            // Search item by ID
//                            Console.Write("Enter Item ID to search: ");
//                            if (int.TryParse(Console.ReadLine(), out int searchId))
//                            {
//                                inventory.SearchById(searchId);
//                            }
//                            else
//                            {
//                                Console.WriteLine("Invalid ID! Please enter a valid number.");
//                            }
//                            break;

//                        case "7":
//                            // Search item by Name
//                            Console.Write("Enter Item Name to search: ");
//                            string name = Console.ReadLine();
//                            inventory.SearchByItemName(name);
//                            break;

//                        case "8":
//                            // Display inventory
//                            inventory.DisplayInventory();
//                            break;

//                        case "9":
//                            // Sort inventory
//                            inventory.SortInventory();
//                            Console.WriteLine("Inventory sorted by Item ID.");
//                            break;

//                        case "10":
//                            // Calculate total inventory value
//                            inventory.CalculateInventory();
//                            break;

//                        case "11":
//                            // Exit the program
//                            Console.WriteLine("Exiting the program...");
//                            return;

//                        default:
//                            Console.WriteLine("Invalid choice! Please enter a number between 1 and 11.");
//                            break;
//                    }
//                }
//            }

//            // Function to take item details from the user
//            private static InventoryItem GetInventoryItemFromUser()
//            {
//                Console.Write("Enter Item ID: ");
//                int itemID = int.Parse(Console.ReadLine());

//                Console.Write("Enter Item Name: ");
//                string itemName = Console.ReadLine();

//                Console.Write("Enter Quantity: ");
//                int quantity = int.Parse(Console.ReadLine());

//                Console.Write("Enter Price: ");
//                double price = double.Parse(Console.ReadLine());

//                return new InventoryItem(itemID, itemName, quantity, price);
//            }
//        }



//    }
