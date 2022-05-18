using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class Beden : IEntity
    {
        [Key]
        public int BedenID { get; set; }
        public int BedenNo { get; set; }
        public virtual List<Manken> Mankens { get; set; }
    }
}
