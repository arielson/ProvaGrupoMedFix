using System;
using System.Collections.Generic;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Presentation.Controllers.api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        //private readonly IContatoRepository _contatoService;
        private readonly IContatoApplicationService _contatoService;

        public ContatoController(IContatoApplicationService contatoService)
        {
            _contatoService = contatoService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_contatoService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            ContatoDTO contato = _contatoService.GetById(id);
            if(contato != null)
                return Ok(contato);
            else
                return NotFound();
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ContatoDTO contato)
        {
            try
            {
                if (contato == null)
                    return NotFound();

                _contatoService.Add(contato);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ContatoDTO contatoDTO)
        {
            try
            {
                if (contatoDTO == null)
                    return NotFound();

                _contatoService.Update(contatoDTO);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ContatoDTO contatoDTO)
        {
            try
            {
                if (contatoDTO == null)
                    return NotFound();

                _contatoService.Remove(contatoDTO);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
