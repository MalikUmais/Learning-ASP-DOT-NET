using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Models;

namespace MyApi.Interfaces
{
    public interface IStockRepository 
    {
        Task<List<Stock>> GetAllAsync();
    }
}