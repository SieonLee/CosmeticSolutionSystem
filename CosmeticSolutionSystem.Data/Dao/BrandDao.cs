using CosmeticSolutionSystem.Data.Models;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data
{
    public class BrandDao : SingleKeyDao<Brand, int>
    {
        internal BrandDao() { }
        protected override Expression<Func<Brand, int>> KeySelector
        {
            get
            {
                return x => x.BrandId;
            }
            
        }
        
        public static List<Brand> GetByBrandName()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Brands
                                //where x.BrandName == BrandName
                                //where x.BrandName.All(t => t.Name.Contains(BrandName))
                            select x;

                return query.ToList();

            }
        }

/*        public List<YearlyBrandSaleModel> GetBrand(DateTime startDate, DateTime endDate)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Brands
                            from p in context.Products
                            where x.BrandId == p.ProductId
                            select new
                            {
                                brandName = x.BrandName
                            };


                var query2 = from x in context.SalesLines
                             from p in context.Sales
                             where x.SalesId == p.SalesId
                             select new
                             {
                                 selledAt = p.SelledAt,
                                 totalPrice = p.TotalPrice
                             };

                var Datequery = from x in context.Sales
                                where x.SelledAt >= startDate && x.SelledAt <= endDate
                                select x;

                var groupDate = from x in Datequery
                                where x.SelledAt.Year >= 2018 && x.SelledAt.Year <= 2020
                                select x;
            }
        }
*/    }
}