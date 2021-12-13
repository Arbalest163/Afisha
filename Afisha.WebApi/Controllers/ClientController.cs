using Afisha.Application.Clients.Commands.CreateClient;
using Afisha.Application.Clients.Queries.GetClientList;
using Afisha.WebApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Afisha.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : BaseController
    {
        private readonly IMapper _mapper;

        public ClientController(IMapper mapper) => _mapper = mapper;

        [HttpGet("ClientList")]
        public async Task<ActionResult<ClientListVm>> Get(string query = null)
        {
            var returnClientList = new GetClientListQuery
            {
                Query = query
            };
            var vm = await Mediator.Send(returnClientList);
            return Ok(vm);
        }

        [HttpPost("CreateClient")]
        public async Task<ActionResult<Guid>> Create([FromForm] CreateClientDto createClientDto)
        {
            var command = _mapper.Map<CreateClientCommand>(createClientDto);
            var clientId = await Mediator.Send(command);
            return Ok(clientId);
        }
    }
}
