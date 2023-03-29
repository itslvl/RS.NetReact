using AutoMapper;
using Domain.R;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ROrgType, ROrgType>();
        }
    }
}