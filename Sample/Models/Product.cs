using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public int Quantidade { get; set; }
        public int Ano { get; set; }
        public bool Is_InPromotion { get; set; }
        public bool Is_Highlighted { get; set; }

        public bool Is_Deleted { get; set; }
        public string Deleted_At { get; set; }
        public string Created_At { get; set; }
        public string Modified_At { get; set; }
    }
}