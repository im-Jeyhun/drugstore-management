using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstoreManagement.DataBase.Models
{
    public class Owner : User
    {
        public Owner(string name , string surName , string Finn):base(name,surName,Finn)
        {

        }
    }
}
