using AutoMapper;
using TryMe.Domain.Entities;
using TryMe.Domain.Responses;

namespace TryMe.Mapper
{
    public class AnswerMapperProfile : Profile
    {
        public AnswerMapperProfile()
        {
            CreateMap<Answer, AnswerResponse>();
        }
    }
}
