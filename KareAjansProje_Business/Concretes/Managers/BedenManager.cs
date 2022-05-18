using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Concretes.Managers
{
    public class BedenManager
    {
        IBedenDal _bedenDal;
        public BedenManager(IBedenDal bedenDal)
        {
            _bedenDal = bedenDal;
        }

        public List<Beden> GetBedens()
        {
            return _bedenDal.GetAll();
        }
    }
}
