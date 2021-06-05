using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;
using WebTest.ViewModel;

namespace WebTest.Mapper
{
    public class Mapping:Profile
    {
        public Mapping() 
        {
            CreateMap<User , UserVM>().ReverseMap();
            CreateMap<Message , MessageVM>().ReverseMap();
        }
    }
}
