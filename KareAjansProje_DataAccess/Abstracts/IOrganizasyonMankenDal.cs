using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_DataAccess.Abstracts
{
    public interface IOrganizasyonMankenDal : IEntityRepositoryDal<OrganizasyonManken>
    {
        List<Organizasyon> GetOrganizasyonByMankens(Expression<Func<OrganizasyonManken, bool>> filter = null);
        List<Manken> GetMankenByOrganizasyons(Expression<Func<OrganizasyonManken, bool>> filter = null);
    }
}
