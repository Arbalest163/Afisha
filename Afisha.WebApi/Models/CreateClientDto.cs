using Afisha.Application.Clients.Commands.CreateClient;
using Afisha.Application.Common.Mappings;
using AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace Afisha.WebApi.Models
{
    public class CreateClientDto : IMapWith<CreateClientCommand>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateClientDto, CreateClientCommand>()
                .ForMember(cC=>cC.FirstName, opt=>opt.MapFrom(cD=>cD.FirstName))
                .ForMember(cC=>cC.LastName, opt=>opt.MapFrom(cD=>cD.LastName))
                .ForMember(cC=>cC.MiddleName, opt=>opt.MapFrom(cD=>cD.MiddleName))
                .ForMember(cC=>cC.Birthday, opt=>opt.MapFrom(cD=>cD.Birthday))
                .ForMember(cC=>cC.Email, opt=>opt.MapFrom(cD=>cD.Email))
                .ForMember(cC=>cC.PhoneNumber, opt=>opt.MapFrom(cD=>cD.PhoneNumber));
        }
    }
}
