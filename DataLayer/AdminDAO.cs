using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;


namespace DataLayer
{
    public class AdminDAO
    {
        HMSEntities db = new HMSEntities();

        public bool IsValidAdmin(string userName, string password)
        {
            int objHMS = db.tblAdmins.Where(m => m.UserName == userName && m.Password == password).Select(m=>m.ID).FirstOrDefault();
            if (objHMS >0)
            {
                return true;
            }

            return false;
        }
    }
}
