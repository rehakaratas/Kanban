using Kanban.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Context
{
    public class KanbanDbContext:DbContext
    {

        public KanbanDbContext():base("Server=DESKTOP-GQND9IH;Database=KanbanDB;Trusted_Connection=True;")
        {

        }

        public DbSet<People> Peoples { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PeopleMapping());
        }
    }

    
}
