using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BO;
using TP02M05.Annontations;

namespace TP02M05.Models
{
    public class PizzaViewModel
    {
        [Checker(new string[] { "Nom" }, Checker.CheckerAction.Length, Checker.CheckerAction.Required, Checker.CheckerAction.DatasOccurs, LengthMin = 5, LengthMax = 25, OccurMin = 0, OccurMax = 0)]
        public Pizza Pizza { get; set; }
        public List<SelectListItem> Ingredients { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Pates { get; set; } = new List<SelectListItem>();

        [Required]
        [Checker(null, Checker.CheckerAction.Required)]
        public int? IdPate { get; set; }

        [Checker(null, Checker.CheckerAction.Length, LengthMin = 2, LengthMax = 5)]
        public List<int> IdsIngredients { get; set; } = new List<int>();
    }
}