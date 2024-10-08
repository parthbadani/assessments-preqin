﻿using Common.Models;

namespace Repository.Interfaces
{
    public interface IInvestorRepository
    {
        public Task<List<Investor>> GetInvestors();
    }
}
