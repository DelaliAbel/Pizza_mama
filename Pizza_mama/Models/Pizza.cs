using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace Pizza_mama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string Nom { get; set; }
        [Display(Name = "Prix")]
        public float Prix { get; set; }
        [Display(Name = "Végétarien")]
        public bool Vegetarien { get; set; }
        [Display(Name = "Ingrédient")]
        [JsonIgnore]
        public string Ingredient { get; set; }

        [NotMapped]// Ne pas prendre en compte par Entity
        [JsonPropertyName("Ingredient")]
        public List<string> IngredientList
        {
            get
            {
                if((Ingredient ==null) && (Ingredient.Count()==0)) 
                {
                    return null;
                }

                return Ingredient.Split(',').ToList();
            }
        }

    }
}
