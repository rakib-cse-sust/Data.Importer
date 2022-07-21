using Application.Models;
using AutoMapper;
using Domain.Entities;

namespace DataImporter.API.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Organisation, OrganisationViewModel>().ReverseMap();
        }
    }
}
