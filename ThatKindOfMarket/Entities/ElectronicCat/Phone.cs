using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThatKindOfMarket.Entities.Abstracts;

namespace ThatKindOfMarket.Entities.ElectronicCat
{
    public class Phone : Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? Stock { get; set; }
        public string? Description { get; set; }
        public int ElectronicId { get; set; }
        public virtual Electronic Electronic { get; set; }
    }
}
