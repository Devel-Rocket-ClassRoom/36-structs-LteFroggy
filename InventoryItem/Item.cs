namespace InventoryItem {
    internal struct Item {
        public string Name;
        public double Weight;
        public int Price;

        public Item(string name, double weight, int price) {
            Name = name;
            Weight = weight;
            Price = price;
        }
    }
}
