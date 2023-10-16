using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Telefon { get; set; }
        public string? E_mail { get; set; }         
        public string? Kullanici_Adi { get; set; }
        public string? Sifre { get; set; }
        public string? rol { get; set; }

    }
}
