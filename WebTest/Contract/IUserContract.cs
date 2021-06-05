using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Contract
{
    public interface IUserContract 
    {
        public bool Insert(User NewUser);
        public bool Update(User NewUser);
        public bool Remove(User NewUser);
        public User getId(string Phone);
        public List<User> getAll();

    }
}
