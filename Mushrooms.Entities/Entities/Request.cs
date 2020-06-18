using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mushrooms.Entities.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime DateTime { get; set; }
        public byte RequestStatusId { get; set; }

    }
}
