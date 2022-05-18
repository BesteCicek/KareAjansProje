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
    public class EfMankenDal : EfEntityRepositoryDal<Manken, KareAjansContext>, IMankenDal
    {
        public List<Manken> GetMankensByOrganizasyons(Expression<Func<Manken, bool>> filter = null)
        {
            using (KareAjansContext db = new KareAjansContext())
            {
                if (filter == null)
                {
                    return db.Set<Manken>().Include("Organizasyon").ToList();
                }
                else
                {
                    return db.Set<Manken>().Include("Organizasyon").Where(filter).ToList();
                }
            }
        }
    }
}
