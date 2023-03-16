using Microsoft.AspNetCore.Mvc;
using Pizza_mama.Data;
using Pizza_mama.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizza_mama.Controlers
{
    [Route("[controller]")]
    [ApiController]
    //[Route("GetPizzas")]
    public class ApiController : Controller
    {
        Pizza_mama.Data.DataContext _DContext { get; set; }

        public ApiController(DataContext DContext)
        {
            _DContext= DContext;
        }

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetAsyncPizzas()
        {
            var pizza = _DContext.Pizzas.ToList();
            //var pizza = new Pizza() { Nom="Pizza test", Prix=8, Vegetarien=false, Ingredient="tomate, oignon, oeuf, poulet"};
            return Json(pizza);
        }
    }
}
