using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackagingChallenge.Business.ServiceModels;

namespace PackagingChallenge.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PackController : ControllerBase
    {        
        [HttpGet]
        public ActionResult<bool> Ping()
        {
            return true;
        }

        [HttpPost]
        public ActionResult<List<List<string>>> Post([FromBody] List<PackageServiceModel> package)
        {
            //TODO
            /*
             * Call PackagingChallenge.Business domain with this logic implemented there using IoC and
             * constructor dependency injection.
             * Implement in PackagingChallenge.Domain layer entity framework code first and repository/ unit of work pattern
             * to access database. 
             */
            List<List<string>> packageResult = new List<List<string>>();           

            foreach (var pack in package)
            {
                List<string> packageIndexList = new List<string>();
                decimal MaxWeight = 0;
                foreach (var item in pack.PackageList)
                {
                    if (item.Cost > 100)
                    {
                        throw new FormatException();
                    }
                    else
                    {                        
                        packageIndexList.Add(item.IndexNumber.ToString());
                        MaxWeight = MaxWeight + item.Weight;
                    }
                }

                if (MaxWeight > pack.MaxWeight || pack.MaxWeight > 100)
                {                   
                    throw new FormatException();
                }

                packageResult.Add(packageIndexList);                
            }            

            return packageResult;
        }         
    }
}
