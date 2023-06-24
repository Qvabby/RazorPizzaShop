using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDb = FakeData.FakePizzaDb;
        public void OnGet()
        {
        }

    }
}
