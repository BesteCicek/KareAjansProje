using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Concretes.Managers
{
    public class SehirManager
    {
        ISehirDal _sehirDal;
        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public List<Sehir> GetSehirs()
        {
            return _sehirDal.GetAll();
        }
    }
}
