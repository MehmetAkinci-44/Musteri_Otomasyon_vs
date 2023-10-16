using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? E_mail { get; set; }
        public string? Telefon { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public string? Meslegi { get; set; }

    }
}
