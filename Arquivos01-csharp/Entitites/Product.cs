namespace Entitites {
    class Product {
        public string Name { get; set; }
        public double Preco { get; set; }
        public int Quantity { get; set; }
        
        public Product() {

        }

        public Product(string name, double preco, int quantity) {
            this.Name = name;
            this.Preco = preco;
            this.Quantity = quantity;
        }

        public double Total() {
             return Preco * Quantity;
        }

        public override string ToString() {
            return Name + ", " + Total().ToString("F2");
        }
    }
}
