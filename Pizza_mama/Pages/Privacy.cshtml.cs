using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pizza_mama.Data;
using Pizza_mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_mama.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext _dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext i_DataContext)
        {
            _logger = logger;
            this._dataContext = i_DataContext;
        }

        public void OnGet()
        {
            var pizza = new Pizza() { Nom="PizzaTest", Prix=54};
            this._dataContext.Add(pizza);
            this._dataContext.SaveChanges();
        }
    }
}
