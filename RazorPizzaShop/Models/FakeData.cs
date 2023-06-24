namespace RazorPizzaShop.Models
{
    public class FakeData
    {
        public static List<PizzasModel> FakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Pepperoni.png",
                PizzaName = "Pepperoni",
                FinalPrice = 5.5f,
                Pepperoni = true,
                Cheese = true,
                Ham = true,

            },
            new PizzasModel()
            {
                ImageTitle = "Margarita.png",
                PizzaName = "Margarita",
                FinalPrice = 5.5f,
                Cheese = true,
                Ham = true,
                TomatoSauce = true,
            },
            new PizzasModel()
            {
                PizzaName = "GayPizza",
                FinalPrice = -2,
                Beef = true,
            },
            new PizzasModel()
            {
                PizzaName = "BlackPizza",
                FinalPrice = 9999,
                Beef = true,
                Ham = true,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
            },
            new PizzasModel()
            {
                PizzaName = "RichPizza",
                FinalPrice = 12321,
                PineApple = true,
            },
            new PizzasModel()
            {
                PizzaName = "YesPizza",
                FinalPrice = 9,
                TomatoSauce = true,
            },
        };
    }
}
