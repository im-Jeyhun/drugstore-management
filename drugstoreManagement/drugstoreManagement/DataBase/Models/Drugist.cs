using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstoreManagement.DataBase.Models
{
    public class Drugist : User
    {
        public string Education { get; set; }
        public string Experience { get; set; }

        public Drugist(string name , string surName , string Finn ,string education, string experience) :base(name,surName,Finn)
        {
            Education = education;
            Experience = experience;
        }
    }
}
