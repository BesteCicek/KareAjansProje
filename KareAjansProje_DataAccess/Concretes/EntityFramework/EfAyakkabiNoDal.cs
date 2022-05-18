using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_DataAccess.Concretes.EntityFramework
{
    public class EfAyakkabiNoDal : EfEntityRepositoryDal<AyakkabiNo, KareAjansContext>, IAyakkabiNoDal
    {
    }
}
