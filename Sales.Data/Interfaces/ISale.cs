
namespace Sales.Business.Interfaces
{
    using System.Threading.Tasks;
    using SalesApp.Model;
    using System.Collections.Generic;

    public interface ISale
    {
        Task<SaleMaster> AddAsync(SaleMaster sale);
        Task DeleteAsync(int SaleMasterId);
        SaleMaster ActiveInactiveSale(SaleMaster sale);
        Task<SaleMaster> GetSaleAsync(int SaleMasterId);
        Task<IEnumerable<SaleMaster>> GetSalesAsync();
    }
}
