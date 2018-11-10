using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrent.DBModels
{
   public class Rent
    {
        public int Id { get; set; }
        //public Customer Customer { get; set; }
        //public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public CarInfo CarInfo { get; set; }
        public int CarInfoId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
