using Kanban.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban
{
    public class People : IPeople
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string YapilanIs { get; set; }
        public Status Status { get; set; }
    }
}
