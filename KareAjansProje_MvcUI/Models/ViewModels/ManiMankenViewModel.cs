using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KareAjansProje_MvcUI.Models.ViewModels
{
    public class ManiMankenViewModel
    {
        public Manken Manken { get; set; }
        public List<Beden> Bedens { get; set; }
        public List<SacRengi> SacRengis { get; set; }
        public List<GozRengi> GozRengis { get; set; }
    }
}