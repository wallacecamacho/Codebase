using AutoMapper;

namespace Codebase.Features.Profiles
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Person, Profile>(MemberList.None);
        }
    }
}
