using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server
{
        [Route("nominations")]
        [ApiController]
        public class NominationController : Controller
        {
            private readonly PizzaStoreContext _db;

            public NominationController(PizzaStoreContext db)
            {
                _db = db;
            }

            [HttpGet]
            public async Task<ActionResult<List<Nomination>>> GetNominations()
            {
                return (await _db.Nominations.ToListAsync()).OrderBy(s => s.Name).ToList();
            }
        }
}