using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace Repository
{
    public class PhoneRepository : BaseRepository
    {
        public PhoneRepository(BusinessDBContext db) : base(db)
        {

        }

        public IQueryable<Phone> GetAll()
        {
            return DB.Phones.AsQueryable();
        }

        //public string Add(Phone phone)
        //{
        //    Phone added = DB.Phones.Add(phone);
        //    DB.SaveChanges();
        //    return added.Id;
        //}


    }
}
