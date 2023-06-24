using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RazorPizzaShop.Data;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public PizzasModel Pizza { get; set; }
        public string PizzaName { get; set; }
        public float FinalPrice { get; set; }
       

        private readonly ApplicationDbContext dbcontext;

        public List<PizzasModel> FakePizzaDb = FakeData.FakePizzaDb;
        public CheckoutModel(ApplicationDbContext db)
        {
            dbcontext = db;
        }
        public void OnGet()
        {
            if (Pizza.FinalPrice == null || Pizza.FinalPrice == 0)
            {
                foreach (var item in FakePizzaDb)
                {
                    if (item.PizzaName == PizzaName)
                    {

                        Pizza = item;
                    }
                }

            }
            else
            {
                PizzaName = Pizza.PizzaName;
                FinalPrice = Pizza.FinalPrice;
            }
            if (string.IsNullOrEmpty(Pizza.ImageTitle))
            {
                Pizza.ImageTitle = "customPizza";
            }
            if (string.IsNullOrEmpty(Pizza.ImageTitle))
            {
                Pizza.ImageTitle = "Custom Pizza";
            }


            PizzaOrder order = new PizzaOrder();
            order.PizzaName = Pizza.PizzaName;
            order.PizzaPrice = Pizza.FinalPrice;

            var booleanProperties = typeof(PizzasModel).GetProperties().Where(p => p.PropertyType == typeof(bool));
            var orderProperties = typeof(PizzaOrder).GetProperties().Where(p => p.PropertyType == typeof(bool));



            //foreach (var property in booleanProperties)
            //{
            //    foreach (var prop in orderProperties)
            //    {
            //        //Get value first
            //        bool value = (bool)property.GetValue(Pizza);
            //        if (value == true) { prop.SetValue(order, true); }
            //        if (value == false) { prop.SetValue(order, false); }
            //        //prop.SetValue(property, property.GetValue(Pizza));
            //        break;
            //    }

            //}
            for (int i = 0; i < booleanProperties.Count(); i++)
            {
                for (int k = 0; k < orderProperties.Count(); k++)
                {
                    k = i;

                    bool Value = (bool)booleanProperties.ToList()[i].GetValue(Pizza);

                    if (Value == true) { orderProperties.ToList()[k].SetValue(order, true); }
                    if (Value == false) { orderProperties.ToList()[k].SetValue(order, false); }

                    break;
                }
            }

            dbcontext.PizzaOrders.Add(order);
            dbcontext.SaveChanges();
        }



    }
}
