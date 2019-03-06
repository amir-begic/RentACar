using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACar.Models;

namespace RentACar.Interfaces
{
    public interface IContractService
    {
        Contract AddContract(Contract newContract);
        Contract GetContract(string contractId);
        List<Contract> GetContracts();
        void UpdateContract(string contractId, Contract contract);
    }
}
