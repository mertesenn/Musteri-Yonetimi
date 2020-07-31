using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistiration.Models
{
    public class PortalUserModel : UserModel
    {
        public override Boolean MernisVerification(long tcNo, int birth_of_date, string name, string surname)
        {
            throw new NotImplementedException();
        }
    }
}