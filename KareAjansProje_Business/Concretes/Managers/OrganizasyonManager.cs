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
    public class OrganizasyonManager : IOrganizasyonService
    {
        private IOrganizasyonDal _organizasyonDal;
        public OrganizasyonManager(IOrganizasyonDal organizasyonDal)
        {
            _organizasyonDal = organizasyonDal;
        }

        public List<Organizasyon> GetOrganizasyons()
        {
            return _organizasyonDal.GetAll();
        }
    }
}
