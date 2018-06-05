namespace Sales.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using SalesApp.Model;
    using System.Threading.Tasks;
    using Sales.Business.Interfaces;
    using Sales.Data;
    using Microsoft.EntityFrameworkCore;

    public class Sale : ISale
    {

        private SaleDBContext context;

        public Sale(SaleDBContext context)
        {
            this.context = context;
        }

        public async Task<SaleMaster> AddAsync(SaleMaster sale)
        {
            try
            {
                this.context.SaleMasters.Add(sale);
                await (this.context.SaveChangesAsync());
                return sale;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task DeleteAsync(int SaleMasterId)
        {
            throw new NotImplementedException();
        }

        public Task<SaleMaster> GetSaleAsync(int SaleMasterId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SaleMaster>> GetSaleAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SaleMaster>> GetSalesAsync()
        {
            try
            {
                IQueryable<SaleMaster> _saleMaster = this.context.SaleMasters
                                               .Include(product => product.ProductSaleJoins)
                                               .Where(s => s.IsActive == true);
                return _saleMaster.ToList();

            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public SaleMaster ActiveInactiveSale(SaleMaster sale)
        {
            try
            {
                SaleMaster sm = this.context.SaleMasters.Where(p => p.SaleId == sale.SaleId).FirstOrDefault();
                sm.IsActive = sale.IsActive;
                this.context.SaveChanges();
                return sm;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
