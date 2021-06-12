using AutoMapper;
using ECommerce.Service.Response;
using ECommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.MappingProfile
{
    public class BookMapping : Profile
    {
        public BookMapping()
        {
            CreateMap<BookResponse, BookViewModel>();
        }
    }
}
