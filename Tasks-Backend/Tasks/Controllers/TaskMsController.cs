using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tasks.Data;
using Tasks.Model;

namespace Tasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskMsController : ControllerBase
    {
        private readonly TasksDbContext _context;

        public TaskMsController(TasksDbContext context)
        {
            _context = context;
        }

        // GET: api/TaskMs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskM>>> GetTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        // GET: api/TaskMs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskM>> GetTaskM(long id)
        {
            var taskM = await _context.Tasks.FindAsync(id);

            if (taskM == null)
            {
                return NotFound();
            }

            return taskM;
        }

        // PUT: api/TaskMs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskM(long id, TaskM taskM)
        {
            if (id != taskM.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(taskM).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskMExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TaskMs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskM>> PostTaskM([FromBody] TaskM taskM)
        {
            if (taskM == null)
            {
                return BadRequest("Task data is null.");
            }

            taskM.TaskId = 0;
            taskM.CreatedAt = DateTime.UtcNow;
            taskM.UpdatedAt = DateTime.UtcNow;

            _context.Tasks.Add(taskM);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskM", new { id = taskM.TaskId }, taskM);
        }

        // DELETE: api/TaskMs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskM(long id)
        {
            var taskM = await _context.Tasks.FindAsync(id);
            if (taskM == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(taskM);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskMExists(long id)
        {
            return _context.Tasks.Any(e => e.TaskId == id);
        }
    }
}
