using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrent.DBModels
{
   public class CarInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Made { get; set; }
        public string Registration { get; set; }
        public string ImageUrl { get; set; }
        public virtual CarType CarType { get; set; }
        public int CarTypeId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
