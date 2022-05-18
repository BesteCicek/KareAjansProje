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
    public class MankenManager : IMankenService
    {
        private IMankenDal _mankenDal;
        private static MankenManager _mankenManager;
        private MankenManager(IMankenDal mankenDal)
        {
            _mankenDal = mankenDal;
        }
        public static MankenManager CreateSingleton(IMankenDal mankenDal)
        {
            if (_mankenManager == null)
            {
                _mankenManager = new MankenManager(mankenDal);
            }

            return _mankenManager;
        }
        public void AddManken(Manken manken)
        {
            if (manken != null)
            {
                _mankenDal.Add(manken);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteManken(int id)
        {
            if (id > 1)
            {
                _mankenDal.Delete(new Manken { MankenID = id });
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Manken GetManken(int id)
        {
            return _mankenDal.Get(m => m.MankenID == id);
        }

        public List<Manken> GetMankens()
        {
            return _mankenDal.GetAll();
        }



        public void UpdateManken(Manken manken)
        {
            if (manken != null)
            {
                _mankenDal.Update(manken);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }
    }
}
