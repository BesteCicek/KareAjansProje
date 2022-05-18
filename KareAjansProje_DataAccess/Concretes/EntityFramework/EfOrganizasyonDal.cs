using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_DataAccess.Concretes.EntityFramework
{
    public class EfOrganizasyonDal : EfEntityRepositoryDal<Organizasyon, KareAjansContext>, IOrganizasyonDal
    {
        public List<Organizasyon> GetOrganizasyonsByManken(Expression<Func<Organizasyon, bool>> filter = null)
        {
            using (KareAjansContext db = new KareAjansContext())
            {
                if (filter == null)
                {
                    return db.Set<Organizasyon>().Include("Manken").ToList();
                }
                else
                {
                    return db.Set<Organizasyon>().Include("Manken").Where(filter).ToList();
                }
            }
        }
    }
}
