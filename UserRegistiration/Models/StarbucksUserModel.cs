using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistiration.Models
{
    public class StarbucksUserModel : UserModel
    {
        public override Boolean MernisVerification(long tcNo, int birth_of_date, string name, string surname)
        {
            bool durum;
            try
            {
                using (ServiceReference1.KPSPublicSoapClient servis = new ServiceReference1.KPSPublicSoapClient())
                {
                    durum = servis.TCKimlikNoDogrula(tcNo, name.ToUpper(), surname.ToUpper(), birth_of_date);
                }
            }
            catch
            {
                durum = false;
            }
            if (durum == true)
            {
                return durum;
            }
            else
                return durum;
        }
    }
}