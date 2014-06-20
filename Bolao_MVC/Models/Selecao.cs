using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bolao_MVC.Models
{
    [Table ("Selecao")]
    public class Selecao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Continente { get; set; }
        public string Bandeira { get; set; }
    }
}