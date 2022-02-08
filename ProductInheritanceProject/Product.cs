using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {

    public class Product {
        // Properties
        private bool Flag { get; set; } // Created to show other classes won't inherit
        public string Code { get; set; }
        public decimal Price { get; set; } // Creating with a snippet doing prop then pressing Tab twice
        // Method
        public virtual string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}";
        }
        // Constructor
        public Product(string Code, decimal price) {
            Flag = true; // Could do this.Flag
            this.Code = Code; // this.Code is for the Property and Code is the parameter
            Price = price;
        }
        public Product() { // Default constructor

        }
    }
}
