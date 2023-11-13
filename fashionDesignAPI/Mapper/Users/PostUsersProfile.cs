using AutoMapper;

using fashionDesign.Dto.Users.Request;
using fashionDesign.Models;

namespace fashionDesignAPI.Mapper.Users
{
    public class PostUsersProfile : Profile
    {
        public PostUsersProfile()
        {
            CreateMap<PostUsers, User>().ReverseMap();
        }
    }
}
