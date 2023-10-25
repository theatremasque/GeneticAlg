using GeneticAlgorithms.Entity.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeneticAlgorithms.Controllers;

public class TimeTableController : Controller
{
    private readonly DataContext _ctx;
    
    public TimeTableController(DataContext ctx)
    {
        _ctx = ctx;
    }
    
    [HttpGet]
    public async Task<ActionResult> Index()
    {
            var schudels = await _ctx.TimeSlots
                .Include(i => i.Course)
                .ThenInclude(t => t.Teacher)
                .Include(c => c.Course)
                .ThenInclude(s => s.StudentCourses)
                .Include(p => p.Place)
                .Select(s => new TimeSlotDto
                {
                    Course = s.Course.Title,
                    Place = s.Place.Title,
                    Start = s.Start.TotalMilliseconds,
                    End = s.End.TotalMilliseconds,
                    Students = s.Course.StudentCourses.Count,
                    Day = (int)s.Day
                })
                .ToListAsync();

            return View(schudels);
    }
}