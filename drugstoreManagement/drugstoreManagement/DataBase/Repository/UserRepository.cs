using drugstoreManagement.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstoreManagement.DataBase.Repository
{
    public class UserRepository
    {
        private static int _idCounter;

        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }

        }
        //private static List<Report> reports = new List<Report>()
        //{
        //    new Report("ceyhunhaciada@gmail.com", "elieliyev@gmail.com" , "yatib qalmisan yene ")
        //};
        private static List<User> Users { get; set; } = new List<User>()
        {


        };


        public static User Add(User user)
        {
            Users.Add(user);
            return user;
        }

        public static void Delete(User user)
        {
            Users.Remove(user);
        }


        public static List<User> GetAll()
        {
            return Users;
        }

        public static List<Owner> GetOwners()
        {

            List<Owner> owners = new List<Owner>();

            foreach (User user in Users)
            {
                Owner owner = user as Owner;

                if (owner != null)
                {
                    owners.Add(owner);
                }

            }
            return owners;
        }

        public static List<Drugist> GetDrugists()
        {

            List<Drugist> drugists = new List<Drugist>();

            foreach (User user in Users)
            {
                if (user is Drugist)
                {
                    drugists.Add((Drugist)user);
                }
            }
            return drugists;
        }


    }

}
