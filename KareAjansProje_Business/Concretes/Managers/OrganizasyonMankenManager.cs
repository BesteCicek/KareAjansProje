using KareAjansProje_Business.Abstracts;
using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Concretes.Managers
{
    public class OrganizasyonMankenManager : IOrganizasyonMankenService
    {
        private IOrganizasyonMankenDal _organizasyonMankenDal;
        public OrganizasyonMankenManager(IOrganizasyonMankenDal organizasyonMankenDal)
        {
            _organizasyonMankenDal = organizasyonMankenDal;
        }
        public List<Manken> GetMankenByOrganizasyonId(int orgnId)
        {
            return _organizasyonMankenDal.GetMankenByOrganizasyons(o => o.OrganizasyonId == orgnId);
        }

        public List<Organizasyon> GetOrganizasyonByMankenId(int mnknId)
        {
            return _organizasyonMankenDal.GetOrganizasyonByMankens(o => o.MankenId == mnknId);
        }
    }
}
