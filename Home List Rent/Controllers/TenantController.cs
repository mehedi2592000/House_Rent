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
    public class TenantController : ApiController
    {
        [Route("api/Tenant/Get")]
        [HttpGet]
        public HttpResponseMessage GetTenant()
        {
            return Request.CreateResponse(HttpStatusCode.OK,TanantService.GetTanant());
        }

        [Route("api/Tanant/Getid/{id}")]
        [HttpGet]
        public HttpResponseMessage GetTanantid(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, TanantService.GetTanantId(id));
        }

        [Route("api/Tanant/Add")]
        [HttpPost]
        public HttpResponseMessage AddTanant(TanantModel e)
        {
            bool data = TanantService.AddTanant(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Tanant/Edit")]
        [HttpPost]
        public HttpResponseMessage EditTanant(TanantModel e)
        {
            bool data=TanantService.EditTanant(e);
            return Request.CreateResponse(data? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Tanant/Delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteTanant(int id)
        {
            bool data = TanantService.DeleteTanant(id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }
    }
}
