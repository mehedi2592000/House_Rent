using Buseness_Entity_Layer;
using Buseness_Logic_Layer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Home_List_Rent.Controllers
{
    public class HouseOwnerController : ApiController
    {
        [Route("api/Owner/list")]
        [HttpGet]
        public List<OwnerModel>Get()
        {
            return OwnerService.GetAll();
        }

    }
}
