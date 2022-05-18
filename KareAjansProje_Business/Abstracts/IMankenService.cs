using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_Business.Abstracts
{
    public interface IMankenService
    {
        List<Manken> GetMankens();
        Manken GetManken(int id);
        void AddManken(Manken manken);
        void UpdateManken(Manken manken);
        void DeleteManken(int id);
    }
}
