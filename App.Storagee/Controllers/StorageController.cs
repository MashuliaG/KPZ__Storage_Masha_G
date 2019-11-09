using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using App.Storage.Interfaces;
using App.Storage.Models;

namespace App.Storage.Controllers
{

    [Route("api/storage")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        readonly IStorageManager _valuesManager;
        public StorageController(
            IStorageManager valuesManager)
        {
            _valuesManager = valuesManager;
        }

        [HttpGet("AllProducts")]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return _valuesManager.GetProducts().ToList();
        }

        [HttpGet("GetCostById/{Id}")]
        public ActionResult<string> GetCostById(int Id)
        {
            return _valuesManager.GetProductCostById(Id);
        }

        [HttpPost("AddProduct")]
        public void AddProduct(double Cost,int Amount,string Type)
        {
            _valuesManager.AddProduct(Cost, Amount, Type);
        }

        [HttpPost("EditProduct/{Id}")]
        public void EditProduct(int Id,double Cost, int Amount)
        {
            _valuesManager.EditProduct(Id,Cost, Amount);
        }
    }
}

