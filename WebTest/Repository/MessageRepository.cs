using WebTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data;
using Microsoft.EntityFrameworkCore;
using WebTest.Contract;

namespace WebTest.Repository
{
    public class MessageRepository : IMessageContract

    {
        private readonly UserContext _DbUser;
        public MessageRepository(UserContext DbUser)
        {
            _DbUser = DbUser;
        }

        public bool Insert(Message NewUser)
        {
            _DbUser.Messages.Add(NewUser);
            return Save();
        }

        public bool Update(Message NewUser)
        {
            _DbUser.Messages.Update(NewUser);
            return Save();
        }

        public bool Remove(Message NewUser)
        {
            _DbUser.Messages.Remove(NewUser);
            return Save();
        }

        public bool Save()
        {
            var saveChanges = _DbUser.SaveChanges();

            return saveChanges > 0;
        }

        public bool isExists(string id)
        {
            var s = _DbUser.Messages.Any(d => d.Id.Equals(id));
            return false;
        }

        public List<Message> getAll()
        {
            return _DbUser.Messages.Include(s => s.Person).ToList();
        }
        
    }
}
