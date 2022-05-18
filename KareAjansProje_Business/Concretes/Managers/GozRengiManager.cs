using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Concretes.Managers
{
    public class GozRengiManager
    {
        IGozRengiDal _gozRengiDal;
        public GozRengiManager(IGozRengiDal gozRengiDal)
        {
            _gozRengiDal = gozRengiDal;
        }

        public List<GozRengi> GetGozRengis()
        {
            return _gozRengiDal.GetAll();
        }
    }
}
