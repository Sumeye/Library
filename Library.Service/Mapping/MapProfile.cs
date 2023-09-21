using AutoMapper;
using Library.Core.DTO;
using Library.Core.Models;

namespace Library.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Books, BooksDto>().ReverseMap();
            CreateMap<Books, BooksSaveDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Loan, LoanDto>().ReverseMap();
        }
    }
}
