using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class AyakkabiNo : IEntity
    {
        [Key]
        public int AyakkabiNoID { get; set; }
        public int AyakkabiNumarasi { get; set; }
        public virtual List<Manken> Mankens { get; set; }
    }
}
