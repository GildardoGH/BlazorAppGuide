using BlazorAppGuide.Shared;
using BlazorAppGuide.Shared.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppGuide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly AppDbContext context;

        public ActorController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(ActorDto model)
        {
            try
            {
                var actor = new Actor(model.Picture, model.FirstName, model.LastName, model.Biography, model.DateOfBirth, model.YearsActive);

                await context.Actors.AddAsync(actor);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("all")]
        public async Task<List<ActorDto>> GetAll()
        {
            return await context.Actors.Select(a => new ActorDto
            {
                Id = a.Id,
                Picture = a.Picture,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Biography = a.Biography,
                DateOfBirth = a.DateOfBirth,
                YearsActive = a.YearsActive
            }).OrderBy(a => a.FirstName).ToListAsync();
        }

        [HttpGet("as-generic-list")]
        public async Task<List<SelectItem<int>>> GetAsGenericList()
        {
            return await context.Actors.Select(a => new SelectItem<int>
            {
                Value = a.Id,
                Text = $"{a.FirstName} {a.LastName}"
            }).ToListAsync();
        }
    }
}
