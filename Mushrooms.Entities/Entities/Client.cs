using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Mushrooms.Entities.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }
        public int Phone { get; set; }
    }
}
