using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {

    public class Widget : Product {
        // Properties
        public string Size { get; set; } = "Medium"; // Default Size
        public string Color { get; set; } = "Black";
        // Using ToPrint from Product & adding Size & Color
        public override string ToPrint() {
            return $"{base.ToPrint()} | {Size} | {Color}";
        }
        // Constructor
        public Widget(string code, decimal price, string size, string color)
            : base(code, price) {

            Size = size;
            Color = color;
        }
        public Widget() : base() {

        }
    }
}
