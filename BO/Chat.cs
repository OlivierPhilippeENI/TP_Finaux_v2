using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP01M05.BO
{
    public class Chat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public Couleur Couleur { get; set; }
    }
}