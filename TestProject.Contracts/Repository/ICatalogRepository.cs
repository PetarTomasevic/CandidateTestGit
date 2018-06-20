﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;

namespace TestProject.Contracts.Repository
{
    public interface ICatalogRepository
    {
        Task<List<Catalog>> GetCatalogsAsync();
        Task<int> CreateAsync(Catalog catalog);
        Task<int> EditAsync(Catalog catalog);
        Task<bool> CatalogExists(int id);
        Task<Catalog> FindAsync(int id);
    }
}
