using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Services;
using TestProject.Infrastructure;

namespace TestProject.Client.Views
{
    public class CatalogsController : Controller
    {
        private readonly ICatalogService _catalogService;

        public CatalogsController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        // GET: Catalogs
        public async Task<IActionResult> Index()
        {
            return View(await _catalogService.GetCatalogsAsync());
        }

        // GET: Catalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
          
            return View();
        }

        // GET: Catalogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catalogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CatalogName,CatalogDescription,CreatedBy,CreatedDateUtc,LastModifiedBy,LastModifiedDateUtc,IsDeleted")] Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                if (await _catalogService.CreateAsync(catalog) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(catalog);
        }

        // GET: Catalogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalog = await _catalogService.FindAsync(id.Value);
            if (catalog == null)
            {
                return NotFound();
            }
            return View(catalog);
        }

        // POST: Catalogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CatalogName,CatalogDescription,CreatedBy,CreatedDateUtc,LastModifiedBy,LastModifiedDateUtc,IsDeleted")] Catalog catalog)
        {
            if (id != catalog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (await _catalogService.EditAsync(catalog) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(catalog);
        }

        // GET: Catalogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
          
            return View();
        }

        // POST: Catalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            return RedirectToAction(nameof(Index));
        }

      
    }
}
