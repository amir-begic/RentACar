using Microsoft.AspNetCore.Mvc;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_contractService.GetContracts());
        }

        [HttpGet("{contractId}")]
        public JsonResult Get(string contractId)
        {
            return new JsonResult(_contractService.GetContract(contractId));
        }

        [HttpPost]
        public JsonResult Post([FromBody]Contract newContract)
        {
            return new JsonResult(_contractService.AddContract(newContract));
        }

        [HttpPut("{contractId}")]
        public void Put(string contractId, [FromBody]Contract newContract)
        {
            _contractService.UpdateContract(contractId, newContract);
        }
    }
}