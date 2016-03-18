using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using ViewModel;

namespace Service
{
    public class PhoneService : BaseService
    {
        PhoneRepository repository;

        public PhoneService(BusinessDBContext db) : base(db)
        {
            repository = new PhoneRepository(DbContext);
        }

        public List<PhoneViewModel> GetAll()
        {
            IQueryable<Phone> queryable = repository.GetAll();
            var phoneViewModels = queryable.ToList().Select(x => new PhoneViewModel(x)).ToList();
            return phoneViewModels;
        }

        //public string Add(Phone phone)
        //{
        //    return repository.Add(phone);
        //}

    }
}
