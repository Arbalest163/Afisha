using Afisha.Application.Common.Mappings;
using Afisha.Domain;
using AutoMapper;
using System;

namespace Afisha.Application.Clients.Queries.GetClientList
{
    public class ClientDto : IMapWith<Client>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Client, ClientDto>()
                    .ForMember(cD => cD.Id, opt => opt.MapFrom(c => c.Id))
                    .ForMember(cD => cD.FirstName, opt => opt.MapFrom(c => c.FirstName))
                    .ForMember(cD => cD.LastName, opt => opt.MapFrom(c => c.LastName))
                    .ForMember(cD => cD.MiddleName, opt => opt.MapFrom(c => c.MiddleName))
                    .ForMember(cD => cD.Birthday, opt => opt.MapFrom(c => c.Birthday))
                    .ForMember(cD => cD.Email, opt => opt.MapFrom(c => c.Email))
                    .ForMember(cD => cD.PhoneNumber, opt => opt.MapFrom(c => c.PhoneNumber));
        }
    }
}
