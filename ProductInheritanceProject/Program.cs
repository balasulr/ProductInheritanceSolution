using System;
using System.Collections.Generic;

namespace ProductInheritanceProject {
    class Program {
 
        static void Main(string[] args) {
            // Creating a Collection as a List & put instances of Service & Widget
            List<Product> salesOrder = new List<Product>();
            // Creating 3 widgets of different Sizes and a Service
            Product widget1 = new Widget("W1", 50, "Small", "Red");
            Product widget2 = new Widget("W2", 100, "Medium", "White");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);
            // Adding the 4 Products to the collection using the Add method
            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);
            // Display the Sales Order with the Widgets & Service & Total how much will cost
            decimal salesOrderTotal = 0;
            foreach (Product p in salesOrder) {// salesOrder is name of the collection
                salesOrderTotal += p.Price;
                if(p is Widget) { // If p is a widget then create a new variable called w,
                    Widget w = p as Widget; // and convert p to a widget and store in w
                    Console.WriteLine($"{w.Code} {w.Price:c} {w.Size} {w.Color}");
                    continue; //Immediately goes back to start of foreach loop
                }
                if(p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{s.Code} {s.Price:c} {s.ServiceLevel} {s.NumberOfYears}");
                    continue;
                }
            }
            Console.WriteLine($"Total sales order is {salesOrderTotal:c}");

            //// Creating a Service
            //Service s1 = new Service("BASIC", 100, "Basic", 3);
            //Console.WriteLine(s1.ToPrint());

            //// Creating a Widget
            //Widget w = new Widget("Widget", 543.21m, "Large", "MAX Red");
            //Console.WriteLine(w.ToPrint());

            //Widget w1 = new Widget(); // Uses default values
            //Console.WriteLine(w1.ToPrint());

            //// Creating a instance of the Product
            //Product p = new Product("Echo", 123.45m);
            //string message = p.ToPrint();
            //Console.WriteLine(message); // Shorter way to put is cw then tab twice

        }
    }
}
