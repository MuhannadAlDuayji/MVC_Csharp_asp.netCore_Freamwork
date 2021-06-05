using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Contract;
using WebTest.Models;
using WebTest.ViewModel;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserContract _userContract;
        private readonly IMessageContract _messageContract;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger
            , IUserContract userContract
            , IMapper mapper
            , IMessageContract messageContract)
        {
            _logger = logger;
            _userContract = userContract;
            _mapper = mapper;
            _messageContract = messageContract;
        }

        public IActionResult Index()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine();
            var message = _messageContract.getAll();
            var model = _mapper.Map<List<MessageVM>>(message);
            for (int i = 0; i < message.Count; i++)
            {
                model[i].Phone = message[i].Person.Phone;
            }

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            return View(model);
        }
        public IActionResult Create() 
        {
            return View();
        }
        public IActionResult addMessage(MessageVM a)
        {
            
            var userinfo = _userContract.getId(a.Phone);
            Message messageUser = _mapper.Map<Message>(a);
            //messageUser.UserId = userinfo.Id;
            //messageUser.Person = userinfo;
            var newMessage = new Message() { UserId = userinfo.Id, Person = userinfo , Letter=messageUser.Letter,};
            //Message message=new Message();
            //message.UserId = userinfo.Id;
            //message.Letter = a.Letter;
            //message.Person = userinfo;
            _messageContract.Insert(newMessage);
            
            return View("Create");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
