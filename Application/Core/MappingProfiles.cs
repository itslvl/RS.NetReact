using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<OrgType, OrgType>();
            CreateMap<Org, OrgDto>()
            // .ForMember( c => c.)
            // .ForMember( a => a.)
            ;
            CreateMap<OrgType, OrgTypeDto>()
            .ForMember( a => a.Code, b => b.Ignore())    
            
            ;
            // CreateMap<Org, OrgDto>()
            // // .ForMember( a => a.)
            // ;

                // .ForMember( a => a..OrgTypeDtos,  c => c.Ignore());



            // cfg.CreateMap<SourceChildClass, DestinationChildClass>();
            // cfg.CreateMap<SourceClass, DestinationClass>()
            //     .ForMember(dest => dest.Children, opt => opt.MapFrom(src => src.Children));



            // .ForMember( a => a.OrgTypeDto, b => b.MapFrom( c => c.OrgType.OrgType
            // ..Fir))
            ;
            // CreateMap<OrgType, OrgTypeDto>()
            //     .ForMember( a => a.Code, b => b.MapFrom( c => c.Code ))

            // ;
            // .ForMember(a => a.OrgTypeDto, b => b.MapFrom(c => c.OrgType))
            // ;
            // CreateMap<OrgType, OrgTypeDto>()
            // .ForMember( a => a.Code, b => b.MapFrom( s => s.Org
            //     .FirstOrDefault( x => x.Id ).)
            // .ForMember( a => a.Definition, b => b.MapFrom( c => c.Definition))
            // .ForMember( a => a.Display, b => b.MapFrom( c => c.Display))
            // ;
            // .ForMember(a => a.OrgTypeDto, a => a.MapFrom(a => a.OrgType));

        }
    }
}