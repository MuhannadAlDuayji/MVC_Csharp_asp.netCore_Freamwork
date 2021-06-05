using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using WebTest.Contract;
using WebTest.Data;
using WebTest.Models;

namespace WebTest.Repository
{
    public class UserRepository : IUserContract
    {
        //First create var from DbContext
        private readonly UserContext _DbUser;

        public UserRepository(UserContext DbUser) 
        {
            _DbUser = DbUser;
        }

        public bool Insert(User NewUser) 
        {
            _DbUser.UsersTable.Add(NewUser);
            return Save();
        }

        public bool Update(User NewUser)
        {
            _DbUser.UsersTable.Update(NewUser);
            return Save();
        }

        public bool Remove(User NewUser)
        {
            _DbUser.UsersTable.Remove(NewUser);
            return Save();
        }

        public bool Save() 
        {
            var saveChanges = _DbUser.SaveChanges();

            return saveChanges > 0;
        }

        public bool isExists(string id) 
        {
            var s = _DbUser.UsersTable.Any(d=>d.Id.Equals(id));
            return false;
        }

        public User getId(string Phone) 
        {
            var user = _DbUser.UsersTable.FirstOrDefault(d => d.Phone.Equals(Phone));
            return user;
        }

        public User getPhone(int iid)
        {
            var user = _DbUser.UsersTable.FirstOrDefault(d => d.Phone.Equals(iid));
            return user;
        }

        public List<User> getAll()
        {
            return _DbUser.UsersTable.ToList();
        }



    }
}
