using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class BaseService
    {
        protected BusinessDBContext DbContext;
        public BaseService(BusinessDBContext db)
        {
            this.DbContext = db;
        }
    }
}
