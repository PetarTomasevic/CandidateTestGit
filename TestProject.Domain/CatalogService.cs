using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Repository;
using TestProject.Contracts.Services;

namespace TestProject.Domain
{
   public  class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _catalogRepository;

        public CatalogService(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }
        public async Task<List<Catalog>> GetCatalogsAsync()
        {
            var result = new List<Catalog>();
            result = await _catalogRepository.GetCatalogsAsync();
            return result;
        }

        public async Task<int> CreateAsync(Catalog catalog)
        {
            var result=0;
            result = await _catalogRepository.CreateAsync(catalog);
            return result;

        }

        public async Task<Catalog> FindAsync(int id)
        {
            var result = new Catalog();
            result = await _catalogRepository.FindAsync(id);
            return result;

        }

        public async Task<int> EditAsync(Catalog catalog)
        {
            var result = 0;
            if (!await _catalogRepository.CatalogExists(catalog.Id))
            {
                return result;
            }
            try
            {
                result= await _catalogRepository.EditAsync(catalog);
            }
            catch (Exception ex)
            {
               //log error
            }
            return result;
        }
        public async Task<bool> CatalogExists(int id)
        {
            var result = false;
            if (await _catalogRepository.CatalogExists(id))
            {
                result = true;
            }
            return result;
        }
    }
}
