using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;


namespace SalesApp.Controllers
{
    using Sales.Business.Interfaces;
    using SalesApp.Model;
    using System.Threading.Tasks;
    [Route("api/[controller]/[action]")]
    [EnableCors("CorsPolicy")]
    public class SaleController : Controller
    {
        private ISale ISale;
        public SaleController(ISale _ISale)
        {
            this.ISale = _ISale;
        }

        [HttpPost(Name = "UpdateSale")]
        public IActionResult UpdateSale([FromBody] SaleMaster _saleMaster)
        {
            try
            {
                return new OkObjectResult(this.ISale.ActiveInactiveSale(_saleMaster));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost(Name = "AddSale")]
        public async Task<IActionResult> AddSale([FromBody] SaleMaster _saleMaster)
        {
            try
            {
                SaleMaster sm = await this.ISale.AddAsync(_saleMaster);
                return new OkObjectResult(sm);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet(Name = "GetSales")]
        public IActionResult GetSales()
        {
            try
            {
                Task<IEnumerable<SaleMaster>> _TsaleMaster = this.ISale.GetSalesAsync();
                return new OkObjectResult(Task.Run(async () => await _TsaleMaster).Result);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
