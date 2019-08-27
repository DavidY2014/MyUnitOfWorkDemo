using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkLibary;

namespace UnitOfWork.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var dbContext = new MyDbContext();
                var unitofWork = new UnitOfWorkLibary.UnitOfWork(dbContext);
                unitofWork.WorkOrderUserRepository.Add(new UnitOfWorkLibary.Entites.WorkOrderUser() { WorkOrderId =1});
                //unitofWork.StudentRepository.Add(new UnitOfWorkLibary.Entites.Student() { Name = "jack" });
                //unitofWork.TecherRepository.Add(new UnitOfWorkLibary.Entites.Techer() { Name = "techer wang" });
                //unitofWork.Commit();
                unitofWork.Commit();
                return new string[] { "value1", "value2" };
            }
            catch (Exception ex)
            {
                
            }
            return new string[] { "value1", "value3" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
