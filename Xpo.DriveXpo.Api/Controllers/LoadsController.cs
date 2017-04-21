using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xpo.DriveXpo.Api.Models;
using Xpo.DriveXpo.Api.Services;

namespace Xpo.DriveXpo.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/loads")]
    public class LoadsController : Controller
    {
        [HttpGet]
        public IEnumerable<Load> Get()
        {
            return LoadService.GetAllLoads();
        }


        [HttpGet("{id}")]
        public Load Get(int id)
        {
            var load = LoadService.GetLoadByLoadId(id);

            return load;
        }
    }

}