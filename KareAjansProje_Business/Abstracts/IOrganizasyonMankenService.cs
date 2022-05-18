using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Abstracts
{
    public interface IOrganizasyonMankenService
    {
        List<Organizasyon> GetOrganizasyonByMankenId(int mnknId);
        List<Manken> GetMankenByOrganizasyonId(int orgId);
    }
}
