using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza_mama.Data;
using Pizza_mama.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza_mama.Pages
{
    public class MenuPizzasModel : PageModel
    {
        DataContext DContext { get; set; }
        public IList<Pizza> PizzaList { get; set; } = new List<Pizza>();

        public MenuPizzasModel(DataContext dContext)
        {
            DContext = dContext;
        } 

        public async Task OnGetAsync()
        {
            PizzaList = await DContext.Pizzas.ToListAsync();
        }
    }
}
