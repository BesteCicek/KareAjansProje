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
    public class EfOrganizasyonMankenDal : EfEntityRepositoryDal<OrganizasyonManken, KareAjansContext>, IOrganizasyonMankenDal
    {
        public List<Manken> GetMankenByOrganizasyons(Expression<Func<OrganizasyonManken, bool>> filter = null)
        {
            using (KareAjansContext db = new KareAjansContext())
            {
                if (filter == null)
                {
                    return db.Set<Manken>().Include("Organizasyon").ToList();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

        }

        public List<Organizasyon> GetOrganizasyonByMankens(Expression<Func<OrganizasyonManken, bool>> filter = null)
        {
            using (KareAjansContext db = new KareAjansContext())
            {
                if (filter == null)
                {
                    return db.Set<Organizasyon>().Include("Manken").ToList();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
