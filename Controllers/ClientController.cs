using Microsoft.AspNetCore.Mvc;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        public ActionResult Create(ClientCreateDto client)
        {
            var result = _clientService.Create(client);

            return CreatedAtAction("GetById", new { clientId = result.ClientId }, result);
        }

        [HttpGet("{clientId}")]
        public ActionResult<ClientDto> GetById(int clientId)
        {
            return _clientService.GetById(clientId);
        }

        [HttpGet]
        public ActionResult<DataCollection<ClientDto>> GetAll(int page, int take)
        {
            return _clientService.GetAll(page, take);
        }

        [HttpGet("login")]
        public ActionResult<ClientDto> GetByUsernameAndPassword(ClientLoginDto model)
        {
            return _clientService.GetByUsernameAndPassword(model);
        }

        [HttpPut("{clientId}")]
        public ActionResult Update(int clientId, ClientUpdateDto model)
        {
            _clientService.Update(clientId, model);
            return Ok();
        }

        [HttpDelete("{clientId}")]
        public ActionResult Remove(int clientId)
        {
            _clientService.Remove(clientId);
            return Ok();
        }
    }
}
