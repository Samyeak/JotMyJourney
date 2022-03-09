using JotMyJourney.Core.Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JotMyJourney.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : BaseModel
    {
        private readonly GenericLogic<T> logic;

        public BaseController()
        {

        }

        // GET: api/<BaseController>
        [HttpGet]
        public virtual async Task<IEnumerable<T>> Get()
        {
            return await logic.GetListAsync();
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public virtual async Task<T> Get(int id)
        {
            return await logic.GetAsync(id);
        }

        // POST api/<BaseController>
        [HttpPost]
        public virtual async void Post([FromBody] T model)
        {
            await logic.AddAsync(model);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public virtual async void Put(int id, [FromBody] T model)
        {
            await logic.UpdateAsync(model);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public virtual async void Delete(int id)
        {
            await logic.DeleteAsync(id);
        }
    }
}
