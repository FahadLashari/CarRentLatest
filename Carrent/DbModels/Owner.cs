using Carrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrent.DBModels
{
   public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CarInfo CarInfo { get; set; }
        public int CarInfoId { get; set; }
        public  ApplicationUser User { get; set; }
        public int  UserId { get; set; }
    }
}
