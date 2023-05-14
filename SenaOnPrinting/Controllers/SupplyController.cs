﻿using AutoMapper;
using BusinessCape.DTOs.Supply;
using BusinessCape.Services;
using DataCape.Models;
using Microsoft.AspNetCore.Mvc;

namespace SenaOnPrinting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplyController : ControllerBase
    {
        private readonly SupplyService _supplyService;
        private readonly IMapper _mapper;

        public SupplyController(SupplyService supplyService, IMapper mapper)
        {
            _supplyService = supplyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var supplyCategories = await _supplyService.GetAllAsync();
            return Ok(supplyCategories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var supplyCategory = await _supplyService.GetByIdAsync(id);
            if (supplyCategory == null)
            {
                return NotFound();
            }
            return Ok(supplyCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SupplyCreateDto supplyDto)
        {
            var supplyToCreate = _mapper.Map<SupplyModel>(supplyDto);

            await _supplyService.AddAsync(supplyToCreate);
            return Ok(supplyToCreate);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, SupplyUpdateDto supplyDto)
        {
            var supplyToUpdate = await _supplyService.GetByIdAsync(supplyDto.IdSupply);

            await _supplyService.UpdateAsync(supplyToUpdate);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _supplyService.DeleteAsync(id);
            return NoContent();
        }
    }
}
