using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JapanoriWebSystem.Models
{
    public class modelProduto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public string precoProduto { get; set; }
        public string statusProduto { get; set; }
    }
}