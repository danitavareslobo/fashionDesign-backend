using AutoMapper;

using fashionDesign.Dto.Companies.Request;
using fashionDesign.Models;

namespace fashionDesignAPI.Mapper.Companies
{
    public class PutCompaniesProfile : Profile
    {
        public PutCompaniesProfile()
        {
            CreateMap<PutCompanies, Company>().ReverseMap();
        }
    }
}