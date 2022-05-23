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
    public class AccountController : ApiController
    {
        [Route("api/Account/List")]
        [HttpGet]
        public HttpResponseMessage GetAccount()
        {
            return Request.CreateResponse(HttpStatusCode.OK,AccountService.GetCost());
        }

        [Route("api/Account/ListByid/{id}")]
        [HttpGet]
        public HttpResponseMessage GetAccountId(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, AccountService.GetAccounttId(id));
        }
    }
}
