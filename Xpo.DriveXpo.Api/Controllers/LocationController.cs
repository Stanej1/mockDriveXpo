using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xpo.DriveXpo.Api.Models;

namespace Xpo.DriveXpo.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/location")]
    public class LocationController : Controller
    {
        // GET: api/Location
        [HttpPost]
        public void Post([FromBody] LoadLocation location)
        {
            // no op
        }
    }
}
