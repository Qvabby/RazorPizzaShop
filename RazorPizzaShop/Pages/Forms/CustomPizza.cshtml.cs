using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            Pizza.FinalPrice = Pizza.BasePrice;
            //Taking every boolean properties instead of using all if and elses, we can reduce it to use 1 ifs
            var booleanProperties = typeof(PizzasModel).GetProperties().Where(p => p.PropertyType == typeof(bool));
            foreach (var property in booleanProperties)
            {
                bool value = (bool)property.GetValue(Pizza);
                //if (string.IsNullOrWhiteSpace(value.ToString()))
                if (value)
                {
                    Pizza.FinalPrice += 1;
                }
            }
            
            return RedirectToPage("/Checkout/Checkout", Pizza);
        }
    }
}
