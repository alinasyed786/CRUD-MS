using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_MS.Model;

namespace CRUD_MS.Data
{
    public class CRUD_MSContext : DbContext
    {
        public CRUD_MSContext (DbContextOptions<CRUD_MSContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_MS.Model.Student> Student { get; set; } = default!;
    }
}
