using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ninject.Activation;
using ServiceCadCli.DTO;
using ServiceCadCli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace WbapiCadCli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly IConfiguration _configuration;


        public ClienteController(
        IConfiguration configuration, IClienteService clienteService)
        {
            _configuration = configuration;
            _clienteService = clienteService;
            new ClienteApiSettings(_configuration);
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _clienteService.Get();
               return Ok(result);
               
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message.ToString());
            }
            
        }

        [HttpGet("{nome}")]
        public async Task<IActionResult> GetName(string nome)
        {
            try
            {
                var result = await _clienteService.GetName(nome);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message.ToString());
            }

        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                var result = await _clienteService.Modify(clienteDTO);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message.ToString());
            }

        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                var result = await _clienteService.Insert(clienteDTO);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message.ToString());
            }

        }


        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                
                
                await _clienteService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message.ToString());
            }

        }

    }


}
