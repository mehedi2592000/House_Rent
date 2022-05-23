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
    [EnableCors("*","*","*")]
    public class HouseOwnerController : ApiController
    {
        [Route("api/Owner/list")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, OwnerService.GetAll());
        }

        [Route("api/Owner/list/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, OwnerService.GetId(id));
        }
        

        [Route("api/Owner/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(OwnerModel e)
        {
            bool data=OwnerService.Edit(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Owner/add")]
        [HttpPost]
        public HttpResponseMessage AddOwnere(OwnerModel e)
        {
            bool data=OwnerService.AddOwner(e);
            
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Owner/Delete/{id}")]
        [HttpGet]
        public HttpResponseMessage OwnerDelete(int id)
        {
            bool data = OwnerService.DeleteOwner(id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }
    }
}
