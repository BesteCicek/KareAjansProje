using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class Organizasyon : IEntity
    {
        [Key]
        public int OrganizasyonID { get; set; }
        public int? SehirId { get; set; }
        public string Tarih { get; set; }
        public int? MankenId { get; set; }
        public OrganizasyonManken OrganizasyonManken { get; set; }
        public virtual List<Manken> Mankens { get; set; }
        public virtual List<Sehir> Sehirs { get; set; }
    }
}
