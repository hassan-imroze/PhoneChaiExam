using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Service;
using ViewModel;
using System.Data.Entity;
using System.Web.Mvc;

namespace MyPhoneChai.Controllers
{
    public class BaseController : ApiController
    {
        protected BusinessDBContext Db;

        public BaseController()
        {
            Db = new BusinessDBContext();
        }
    }
}
