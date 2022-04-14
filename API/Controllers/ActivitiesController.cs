using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;


        public ActivitiesController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]


        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            Console.WriteLine(_context.Activities.ToListAsync());
            return await _context.Activities.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GenActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}