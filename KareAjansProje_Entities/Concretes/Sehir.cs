using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class Sehir : IEntity
    {
        [Key]
        public int SehirID { get; set; }
        public string SehirAd { get; set; }
        public Organizasyon Organizasyon { get; set; }
    }
}
