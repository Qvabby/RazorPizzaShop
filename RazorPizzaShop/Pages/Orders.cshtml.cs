using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Data;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext dbcontext;
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        public OrdersModel(ApplicationDbContext db)
        {
            dbcontext = db;
        }
        public void OnGet()
        {
            PizzaOrders = dbcontext.PizzaOrders.ToList();
        }
    }
}
