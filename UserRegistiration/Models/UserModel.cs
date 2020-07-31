using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistiration.Models
{
    public abstract class UserModel
    {
        public long tcNo { get; set; }
        public int birth_of_date { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public abstract Boolean MernisVerification(long tcNo , int birth_of_date , string name , string surname);
    }
}