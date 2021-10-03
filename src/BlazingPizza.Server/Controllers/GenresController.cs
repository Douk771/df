using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server
{
    [Route("genres")]
    [ApiController]
    public class GenresController : Controller
    {
        private readonly PizzaStoreContext _db;

        public GenresController(PizzaStoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genre>>> GetGenres()
        {
            return (await _db.Genres.ToListAsync()).OrderBy(s => s.Name).ToList();
        }
    }
}