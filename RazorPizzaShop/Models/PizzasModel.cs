namespace RazorPizzaShop.Models
{
    public class PizzasModel
    {
        //Main
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2.5f;
        //bools
        public  bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool PineApple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        //Final
        public float FinalPrice { get; set; }
    }
}
