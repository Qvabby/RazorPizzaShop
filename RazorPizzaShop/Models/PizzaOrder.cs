namespace RazorPizzaShop.Models
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }

        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool PineApple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
    }
}
