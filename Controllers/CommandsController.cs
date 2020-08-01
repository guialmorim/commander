using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.DTOs;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase {
        private readonly ICommanderRepository _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepository repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() {
            var commands = _repository.GetAllCommands();
            return Ok(commands);
        }

        // GET api/commands/:id
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id) {
            var commandItem = _repository.GetCommandById(id);

            if (commandItem != null) return Ok(_mapper.Map<CommandReadDto>(commandItem));

            return NotFound();
        }
    }
}