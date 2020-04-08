using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Turntablio.RoleService.Data.Model
{

    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }

        internal T1[] LoadData<T1, T2>(string psql)
        {
            throw new NotImplementedException();
        }

        internal T1[] LoadData<T1, T2>(string psql, object p)
        {
            throw new NotImplementedException();
        }
    }
}
