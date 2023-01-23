using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Mapping
{
    public class PeopleMapping:EntityTypeConfiguration<People>
    {

        public PeopleMapping()
        {
            this.HasKey(x => x.PersonId);
        }
    }
}
