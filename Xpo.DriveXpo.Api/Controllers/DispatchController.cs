using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xpo.DriveXpo.Api.Models;
using Xpo.DriveXpo.Api.Services;

namespace Xpo.DriveXpo.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/dispatch")]
    public class DispatchController : Controller
    {
        [HttpGet("{carrierId}")]
        public IEnumerable<Load> Get(int carrierId)
        {
            return LoadService.GetLoadsByDispatchCarrierId(carrierId);
        }

        [HttpPost]
        public void Post([FromBody] DispatchTicket ticket)
        {
           
            LoadService.AssignCarrierToLoad(ticket.CarrierId, ticket.LoadId);
        }
    }
}