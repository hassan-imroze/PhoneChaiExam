using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;


namespace MyPhoneChai.Controllers
{
    public class PhoneQueryController : BaseController
    {
        //public IHttpActionResult Get()
        //{
        //    PhoneService service = new PhoneService(Db);
        //    var viewModels = service.GetAll();
        //    return Ok(viewModels);
        //}

        PhoneService service;

        public PhoneQueryController()
        {
            service = new PhoneService(Db);
        }

        public IHttpActionResult Get()
        {
            var viewModels = service.GetAll();
            return Ok(viewModels);
        }
    }
}
