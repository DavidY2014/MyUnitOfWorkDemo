using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using NetCore.SmallUnit.EFModels;

namespace WeChatPublc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet("GetInformation")]
        public string GetInformation(int code)
        {
            using (var dbContext = new TestDBContext())
            {
                using (IDbContextTransaction transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.Students.Add(new Students() { Id=DateTime.Now.Second, Name = "API test" + DateTime.Now.Second.ToString() });//call back save message information;
                        dbContext.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return ex.ToString();
                    }
                }
            }
            return "this is information"+code;
        }

        [HttpPost("PostInformation")]
        public string PostInformation([FromBody] string param)
        {
            return "Post success! "+param;
        }

        [HttpGet("GetInformationTest")]
        public string GetInformationTest(int code)
        {

            return "this is GetInformationTest" + code;
        }
    }
}
