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
    public class HouseCaretakerController : ApiController
    {

        [Route("api/Caretaker/Get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CaretakerService.GetCaretaker());
        }

        [Route("api/Caretaker/GetId/{id}")]
        [HttpGet]
        public HttpResponseMessage GetAll(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, CaretakerService.GetCaretakerid(id));
        }

        [Route("api/Caretaker/Add")]
        [HttpPost]
        public HttpResponseMessage AddCaretaker(CaretakerModel e)
        {
            bool data=CaretakerService.AddCaretaker(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK:HttpStatusCode.BadRequest );
        }

        [Route("api/Caretaker/Edit")]
        [HttpPost]
        public HttpResponseMessage EditCaretaker(CaretakerModel e)
        {
            bool data = CaretakerService.EditCaretaker(e);

            return Request.CreateResponse(data ? HttpStatusCode.OK :HttpStatusCode.BadRequest );
        }

        [Route("api/Caretaker/DeleteCaretaker")]
        [HttpGet]

        public HttpResponseMessage DeleteCaretaker(int id)
        {
            bool data = CaretakerService.deleteCaretaker(id);
            return Request.CreateResponse(data ? HttpStatusCode.OK:HttpStatusCode.NotFound );
        }
    }
}
