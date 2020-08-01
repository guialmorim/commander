using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles {
    public class CommandsProfile : Profile {
        public CommandsProfile() {
            CreateMap<Command, CommandReadDto>();
        }
    }
}