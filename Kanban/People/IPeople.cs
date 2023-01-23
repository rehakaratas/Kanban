using Kanban.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban
{
    public interface IPeople
    {

         int PersonId { get; set; }
         string PersonName { get; set; }
         string PersonSurname { get; set; }
         string YapilanIs { get; set; }
         Status Status { get; set; }
    }
}
