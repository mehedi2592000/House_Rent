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
    public class HouseBillController : ApiController
    {

        
        [Route("api/HouseBill/Get")]
        [HttpGet]
        public HttpResponseMessage GetBill()
        {
            return Request.CreateResponse(HttpStatusCode.OK,BillService.GetBill());
        }

        [Route("api/HouseBill/GetBillid/{id}")]
        [HttpGet]
        public HttpResponseMessage GetBillId(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, BillService.GetBillId(id));
        }

        [Route("api/HouseBill/AddBill")]
        [HttpPost]
        public HttpResponseMessage AddBill(BillModel e)
        {
            bool data = BillService.AddBill(e);
            return Request.CreateResponse(data?HttpStatusCode.OK:HttpStatusCode.BadRequest);
        }

        [Route("api/HouseBill/EditBill")]
        [HttpPost]
        public HttpResponseMessage EditBill(BillModel e)
        {
            bool data=BillService.EditBill(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/HouseBill/DeleteBill/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteBill(int id)
        {
            bool data = BillService.DeleteTanant(id);
            return Request.CreateResponse(data? HttpStatusCode.OK: HttpStatusCode.BadRequest);
        }
    }
}
