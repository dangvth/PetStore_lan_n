using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Model
{
    class TypeModel
    {
        List<PetStore.Type> tList;
        PetStoreEntities db;

        public TypeModel()
        {
            db = new PetStoreEntities();
        }

        public List<PetStore.Type> getAllType()
        {
            tList = new List<PetStore.Type>();
            tList = (from t in db.Types select t).ToList();
            return tList;
        }

        public int getIDByTName(string tName)
        {
            Type t = db.Types.FirstOrDefault(x => x.t_name == tName);
            int tId = t.t_id;
            return tId;
        }
    }
}
