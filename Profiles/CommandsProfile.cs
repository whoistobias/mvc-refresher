using AutoMapper;
using Rekt.Dtos;
using Rekt.Models;

namespace Rekt.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}