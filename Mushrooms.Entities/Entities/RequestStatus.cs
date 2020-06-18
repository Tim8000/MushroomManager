using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mushrooms.Entities.Entities
{
    public class RequestStatus
    {
        public byte Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
