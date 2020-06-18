using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mushrooms.Entities.Entities
{
    public class RequestItem
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public byte MushroomTypeId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

    }
}
