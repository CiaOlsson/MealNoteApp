using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLogg.Application.DTOs
{
    public class SaveFoodDTO
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }
    }
}
