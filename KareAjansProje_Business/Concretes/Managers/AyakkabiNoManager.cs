using KareAjansProje_DataAccess.Abstracts;
using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Concretes.Managers
{
    public class AyakkabiNoManager
    {
        IAyakkabiNoDal _ayakkabiNoDal;
        public AyakkabiNoManager(IAyakkabiNoDal ayakkabiNoDal)
        {
            _ayakkabiNoDal = ayakkabiNoDal;
        }

        public List<AyakkabiNo> GetAyakkabiNos()
        {
            return _ayakkabiNoDal.GetAll();
        }
    }
}
