using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class OrganizasyonManken : IEntity
    {
        [Key]
        public int OrganizyonMankenID { get; set; }
        public int? OrganizasyonId { get; set; }
        public int? MankenId { get; set; }
        public string Baslangic { get; set; }
        public string Bitis { get; set; }
        public Manken Manken { get; set; }
        public Organizasyon Organizasyon { get; set; }
        public virtual List<Manken> Mankens { get; set; }
        public virtual List<Organizasyon> Organizasyons { get; set; }
    }
}
