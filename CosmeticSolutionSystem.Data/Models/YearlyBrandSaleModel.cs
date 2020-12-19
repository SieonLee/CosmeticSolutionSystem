using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class YearlyBrandSaleModel
    {
        public string BrandName { get; set; }
        public int BrandId { get; set; }
        public int ProductId { get; set; }
        public int SalesId { get; set; }
        public DateTime SelledAt { get; set; }
        public int TotalPrice { get; set; }
    }
}
