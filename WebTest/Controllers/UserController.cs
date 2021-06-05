using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Contract;
using WebTest.Data;
using WebTest.Models;
using WebTest.ViewModel;

namespace WebTest.Controllers
{
    public class UserController : Controller 
    {
        
        private readonly IUserContract _userInfo;
        private readonly IMapper _mapper;
        public UserController(IUserContract userInfo, IMapper mapper) 
        {
            _userInfo = userInfo;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Create(UserVM user) 
        {
            var toDB = _mapper.Map<User>(user);
            _userInfo.Insert(toDB);
            return View();
        }

       
    }
}
