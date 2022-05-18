using KareAjansProje_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Entities.Concretes
{
    public class Manken : IEntity
    {
        [Key]
        public int MankenID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? SacRengiId { get; set; }
        public int? GozRengiId { get; set; }
        public int? BedenId { get; set; }
        public int AyakkabiNo { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public bool Ehliyet { get; set; }
        public bool YabanciDil { get; set; }
        public bool SehirDisi { get; set; }
        public int? KategoriId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? OrganizasyonId { get; set; }
        public virtual List<Organizasyon> Organizasyons { get; set; }
        public SacRengi SacRengi { get; set; }
        public GozRengi GozRengi { get; set; }
        public Beden Beden { get; set; }
        public Kategori Kategori { get; set; }
        public OrganizasyonManken OrganizasyonManken { get; set; }
    }
}
