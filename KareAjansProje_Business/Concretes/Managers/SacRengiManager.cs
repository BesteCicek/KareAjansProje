using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Concretes.Managers
{
    public class SacRengiManager
    {
        ISacRengiDal _sacRengiDal;
        public SacRengiManager(ISacRengiDal sacRengiDal)
        {
            _sacRengiDal = sacRengiDal;
        }

        public List<SacRengi> GetSacRengis()
        {
            return _sacRengiDal.GetAll();
        }
    }
}