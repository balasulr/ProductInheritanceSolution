using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {
    
    public class Service : Product {
        // Properties
        public string ServiceLevel { get; set; } = "Basic";
        public int NumberOfYears { get; set; } = 1;

        public override string ToPrint() {
            return $"{base.ToPrint()} | {ServiceLevel} | {NumberOfYears}";
        }
        // Constructors
        public Service(string code, decimal price, string serviceLevel, int numberOfYears)
            : base(code, price){ // Calls the Constructors from product
            ServiceLevel = serviceLevel; // Initialize properties in Service class
            NumberOfYears = numberOfYears;
        }
        public Service () { // Default Constructor

        }
    }
}
