using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {
    
    public class Software : Product {
        // Property
        public bool Book { get; set; } = true; // whether should include ook with this value
        // ToPrint Method
        public override string ToPrint() { //Another way is: return $"{base.ToPrint()} | {Book}";
            return $"{base.ToPrint()} | {(Book ? "Yes" : "No")}";
        }
        // Constructors
        public Software(string code, decimal price, bool book)
            : base(code, price) { // Lets the Product Constructor inilize the code & price
            Book = book; // Inilize all properties
        }
        public Software() {

        }

    }
}
