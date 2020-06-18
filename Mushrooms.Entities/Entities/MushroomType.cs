using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mushrooms.Entities.Entities
{
    public class MushroomType
    {
        public byte Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public byte PackageWeight { get; set; }
    }
}
