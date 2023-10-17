using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAnimals.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnimals.Controllers
{
    public class ClienteDireccionController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClienteDireccionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ClienteDireccionDto>>> Get()
        {
            var clienteDireccion = await _unitOfWork.ClienteDirecciones.GetAllAsync();
            return _mapper.Map<List<ClienteDireccionDto>>(clienteDireccion);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDireccionDto>> Get(int id)
        {
            var clienteDireccion = await _unitOfWork.ClienteDirecciones.GetAllAsync();
            if (clienteDireccion == null) return BadRequest();
            return _mapper.Map<ClienteDireccionDto>(clienteDireccion);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDireccion>> Post(ClienteDireccionDto clienteDireccionDto)
        {
            var clienteDireccion = _mapper.Map<ClienteDireccion>(clienteDireccionDto);
            _unitOfWork.ClienteDirecciones.Add(clienteDireccion);
            if (clienteDireccion == null) return BadRequest();
            await _unitOfWork.SaveAsync();
            clienteDireccionDto.Id = clienteDireccion.Id;
            return CreatedAtAction(nameof(Post), new { id = clienteDireccionDto.Id }, clienteDireccionDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDireccionDto>> Put(int id, [FromBody] ClienteDireccionDto clienteDireccionDto)
        {
            if (clienteDireccionDto == null) return NotFound();
            var clienteDireccion = _mapper.Map<ClienteDireccion>(clienteDireccionDto);
            clienteDireccion.Id = id;
            _unitOfWork.ClienteDirecciones.Update(clienteDireccion);
            await _unitOfWork.SaveAsync();
            return clienteDireccionDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var clienteDireccion = await _unitOfWork.ClienteDirecciones.GetByIdAsync(id);
            if (clienteDireccion == null) return NotFound();
            _unitOfWork.ClienteDirecciones.Remove(clienteDireccion);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}