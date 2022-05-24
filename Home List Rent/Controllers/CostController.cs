using Buseness_Entity_Layer;
using Buseness_Logic_Layer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Home_List_Rent.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CostController : ApiController
    {

        [Route("api/Cost/List")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK,CostService.GetCost());
        }

        [Route("api/Cost/ListId/{id}")]
        [HttpGet]
        public HttpResponseMessage GetId(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, CostService.GetCostId(id));
        }

        [Route("api/Cost/Add")]
        [HttpPost]
        public HttpResponseMessage AddCost(CostModel e)
        {
            bool cost = CostService.AddCost(e);
            return Request.CreateResponse(cost?HttpStatusCode.OK:HttpStatusCode.BadRequest);

        }

        [Route("api/Cost/EditCost")]
        [HttpPost]
        public HttpResponseMessage EditCost(CostModel e)
        {
            bool cost=CostService.EditCost(e);
            return Request.CreateResponse(cost ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Cost/DeleteCost/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteCost(int id)
        {
            bool data=CostService.DeleteCost(id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }
        [Route("api/Cost/Listgroupby")]
        [HttpGet]
        public HttpResponseMessage Getgroupby()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CostService.GetGroupbyCost());
        }
    }
}
