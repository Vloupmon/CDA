using System;
using System.Collections.Generic;

namespace GrandPrixEF.Models
{
    public partial class HistoResultats
    {
        public int Idtransaction { get; set; }
        public string Utilisateur { get; set; }
        public DateTime DateHeure { get; set; }
        public string CodeOperation { get; set; }
        public string LibelleOperation { get; set; }
    }
}
