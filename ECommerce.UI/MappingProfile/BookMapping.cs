using AutoMapper;
using ECommerce.UI.Models;
using ECommerce.UI.Models.Response;
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
