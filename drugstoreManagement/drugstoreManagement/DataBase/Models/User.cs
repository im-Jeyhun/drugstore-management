using drugstoreManagement.DataBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstoreManagement.DataBase.Models
{
    public abstract class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Finn { get; set; }

        public User( string name, string surname, string finn)
        {          
            Name = name;
            Surname = surname;
            Finn = finn;
            Id = UserRepository.IdCounter;
        }
    }
}
