using AutoMapper;
using TryMe.Domain.Entities;
using TryMe.Domain.Responses;

namespace TryMe.Mapper
{
    public class QuestionMapperProfile : Profile
    {
        public QuestionMapperProfile()
        {
            CreateMap<Question, QuestionResponse>();

        }
    }
}
