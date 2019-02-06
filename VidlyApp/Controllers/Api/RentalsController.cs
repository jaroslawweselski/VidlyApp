using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyApp.Dtos;

namespace VidlyApp.Controllers.Api
{
    public class RentalsController : ApiController
    {
        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto NewRental) 
        {
            throw new NotImplementedException();
        }
    }
}
