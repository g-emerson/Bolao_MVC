using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bolao_MVC.Models
{
    [Table("Jogo")]
    public class Jogo
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
    }
}
