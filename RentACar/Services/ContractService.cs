using System;
using System.Collections.Generic;
using MongoDB.Driver;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Services
{
    public class ContractService : IContractService
    {

        private readonly IDatabaseContext _databaseContext;

        public ContractService(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Contract AddContract(Contract newContract)
        {
            newContract.Price = CalculatePrice(newContract.Reservation.Car.PricePerDay, newContract.Reservation.From,
                newContract.Reservation.To);

            var db = _databaseContext.GetDatabase();

            var _contracts = db.GetCollection<Contract>("Contracts");
            try
            {
                _contracts.InsertOneAsync(newContract);
                return newContract;
            }
            catch
            {
                return new Contract();
            }
        }

        public Contract GetContract(string contractId)
        {
            var db = _databaseContext.GetDatabase();

            var _contracts = db.GetCollection<Contract>("Contracts");

            return _contracts.Find(c => c.ContractId== contractId).Single();
        }

        public List<Contract> GetContracts()
        {
            var db = _databaseContext.GetDatabase();

            var _contracts = db.GetCollection<Contract>("Contracts");

            return _contracts.Find(reservation => true).ToList();
        }

        public void UpdateContract(string contractId, Contract updatedContract)
        {
            updatedContract.Price = CalculatePrice(updatedContract.Reservation.Car.PricePerDay, updatedContract.Reservation.From,
                updatedContract.Reservation.To);

            var db = _databaseContext.GetDatabase();

            var _contracts = db.GetCollection<Contract>("Contracts");

            _contracts.ReplaceOneAsync(c => c.ContractId == contractId, updatedContract);
        }

        private double CalculatePrice(int pricePerDay, DateTime from, DateTime to)
        {
            return (to - from).TotalDays * pricePerDay;
        }
    }
}
