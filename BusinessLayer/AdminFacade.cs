using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
  public   class AdminFacade
    {
        AdminDAO objAdmin = new AdminDAO();
        public bool IsValidAdmin(string userName, string password)
        {
            return objAdmin.IsValidAdmin(userName, password);
        }
    }
}
