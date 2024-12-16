using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssign
{
    public partial  class  UniContextEntities: DbContext
    {
        public UniContextEntities() : base("name=UniContextEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<Employee1> Employee1 { get; set; }

    }

}
