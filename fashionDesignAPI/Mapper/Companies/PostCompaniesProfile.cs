using AutoMapper;
using fashionDesign.Dto.Companies.Request;
using fashionDesign.Models;

namespace fashionDesignAPI.Mapper.Companies
{
    public class PostCompaniesProfile : Profile
    {
        public PostCompaniesProfile()
        {
            CreateMap<PostCompanies, Company>().ReverseMap();
        }
    }
}