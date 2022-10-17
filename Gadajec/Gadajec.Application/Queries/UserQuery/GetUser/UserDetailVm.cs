using AutoMapper;
using Gadajec.Application.Common.Mappings;
using Gadajec.Domain.ValueObjects;

namespace Gadajec.Application.Queries.UserQuery.GetUser
{
    public class UserDetailVm : IMapFrom<Domain.Entities.User>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedAt { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.User, UserDetailVm>()
                .ForMember(u => u.Name, map => map.MapFrom(src => src.FirstName))
                .ForMember(u => u.Surname, map => map.MapFrom(src => src.LastName))
                .ForMember(u => u.CreatedAt, map => map.MapFrom(src => src.CreatedAt));
        }

        

    }
}
