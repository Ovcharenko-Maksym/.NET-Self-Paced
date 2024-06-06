using Microsoft.EntityFrameworkCore;
using ShopReports.Models;
using ShopReports.Reports;

namespace ShopReports.Services
{
    public class ProductReportService
    {
        private readonly ShopContext shopContext;

        public ProductReportService(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public ProductCategoryReport GetProductCategoryReport()
        {
            var result = from item in shopContext.Categories
                         orderby item.Name
                         select new ProductCategoryReportLine
                         {
                             CategoryId = item.Id,
                             CategoryName = item.Name
                         };

            return new ProductCategoryReport(result.ToList(), DateTime.Now);
        }

        public ProductReport GetProductReport()
        {
            var result = from item in shopContext.Products
                         orderby item.Title
                         select new ProductReportLine
                         {
                             ProductId = item.Id,
                             ProductTitle = item.Title.Title,
                             Price = item.UnitPrice,
                             Manufacturer = item.Manufacturer.Name,
                         };

            return new ProductReport(result.ToList(), DateTime.Now);
        }

        public FullProductReport GetFullProductReport()
        {
            // TODO Implement the service method.
            throw new NotImplementedException();
        }

        public ProductTitleSalesRevenueReport GetProductTitleSalesRevenueReport()
        {
            // TODO Implement the service method.
            throw new NotImplementedException();
        }
    }
}
