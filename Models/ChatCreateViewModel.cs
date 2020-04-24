using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP01M05.BO;

namespace TP01M05.Models
{
    public class ChatCreateViewModel
    {
        public Chat Chat { get; set; }
        public List<Couleur> Couleurs { get; } = new List<Couleur>();
        public int IdCouleur { get; set; }
    }
}