using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    public class BusinessDBContext : DbContext
    {
        public BusinessDBContext() : base("DefaultConnection")
        {

        }
        public DbSet<Phone> Phones { get; set; }
    }
}
