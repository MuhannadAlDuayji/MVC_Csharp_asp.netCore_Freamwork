
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Contract
{
    public interface IMessageContract
    {
        public bool Insert(Message NewUser);
        public bool Update(Message NewUser);
        public bool Remove(Message NewUser);
        public List<Message> getAll();
    }
}
