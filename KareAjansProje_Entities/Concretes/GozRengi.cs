using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class GozRengi : IEntity
    {
        [Key]
        public int GozRengiID { get; set; }
        public string Renk { get; set; }
        public virtual List<Manken> Mankens { get; set; }
    }
}
