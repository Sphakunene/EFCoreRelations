using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase {
        private readonly DataContext _context;

        public CharactersController(DataContext dataContext) {
            _context = dataContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Character>>> GetCharacters(int id) { 
        
            var characters =   await _context.Characters.Where(c => c.Id == id).ToListAsync();

            return characters;

        }
    }
}
