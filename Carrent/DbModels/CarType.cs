using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrent.DBModels
{
   public class CarType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MonthlyRent { get; set; }
        public string DailyRent { get; set; }
        public string HourlyRent { get; set; }
    }
}
