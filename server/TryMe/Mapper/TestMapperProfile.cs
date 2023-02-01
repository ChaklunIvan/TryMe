using AutoMapper;
using TryMe.Domain.Entities;
using TryMe.Domain.Responses;

namespace TryMe.Mapper
{
    public class TestMapperProfile : Profile
    {
        public TestMapperProfile()
        {
            CreateMap<Test, TestResponse>();
        }
    }
}
