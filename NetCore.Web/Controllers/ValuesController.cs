using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.SmallUnit.Extensions;
using NetCore.SmallUnit.Units;

namespace NetCore.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(CustomUnitOfWork customUnitofWork,AnotherUnitOfWork antherUnit)
        {
            //常规业务操作
            customUnitofWork.StudentsRepository.Add(null);

            //可重用业务代码 也是
            customUnitofWork.CustomUnifExtensionMethod(0, "test");

            antherUnit.StudentsRepository.Delete(null);
            //调用业务并不影响，可以自己决定commit时机
            customUnitofWork.CustomUnifExtensionMethod(0, "test2");
            antherUnit.Commit();
            customUnitofWork.Commit();//第二次提交




            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(CustomUnitOfWork customUnitofWork,int id)
        {
            //常规业务操作
            customUnitofWork.StudentsRepository.Add(null);

            //可重用业务代码 也是
            customUnitofWork.CustomUnifExtensionMethod(0, "test");
            customUnitofWork.Commit();//第一次提交
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
