﻿using AutoMapper;
using BusinessCape.DTOs.PaperCut;
using BusinessCape.DTOs.QuotationClient;
using BusinessCape.Services;
using DataCape.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SenaOnPrinting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotationClientController : ControllerBase
    {
        private readonly QuotationClientService _quotationClientService;
        private readonly IMapper _mapper;

        public QuotationClientController(QuotationClientService quotationClientService, IMapper mapper)
        {
            _quotationClientService = quotationClientService;
            _mapper = mapper;
        }
        // GET: api/<QuotationClient>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var quotationClient = await _quotationClientService.GetAllAsync();
            return Ok(quotationClient);
        }

        // GET api/<QuotationClient>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var quotationClient = await _quotationClientService.GetByIdAsync(id);
            if (quotationClient == null)
            {
                return NotFound();
            }
            return Ok(quotationClient);
        }

        // POST api/<QuotationClient>
        [HttpPost]
        public async Task<IActionResult> Add(QuotationClientCreateDto quotationClientDto)
        {
            var quotationClientToCreate = _mapper.Map<QuotationClientModel>(quotationClientDto);

            await _quotationClientService.AddAsync(quotationClientToCreate);
            return Ok(quotationClientToCreate);
        }

        // PUT api/<QuotationClient>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, QuotationClientUpdateDto quotationClientDto)
        {
            var quotationClientToUpdate = await _quotationClientService.GetByIdAsync(quotationClientDto.Id);
            _mapper.Map(quotationClientDto, quotationClientToUpdate);
            await _quotationClientService.UpdateAsync(quotationClientToUpdate);
            return NoContent();
        }

        // DELETE api/<QuotationClient>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _quotationClientService.DeleteAsync(id);
            return NoContent();
        }
    }
}
