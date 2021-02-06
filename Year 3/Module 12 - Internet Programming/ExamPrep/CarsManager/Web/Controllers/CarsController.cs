using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Cars;
using Web.Models.Shared;

namespace Web.Controllers
{
    public class CarsController : Controller
    {
        private const int PageSize = 10;
        private readonly CarsManagerDb _context;

        public CarsController()
        {
            _context = new CarsManagerDb();
        }

        // GET: Cars
        public async Task<IActionResult> Index(CarsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<CarsViewModel> items = await _context.Cars.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new CarsViewModel()
            {
                Id = c.Id,
                Brand = c.Brand,
                Engine = c.Engine,
                Model = c.Model,
                Year = c.Year

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Cars.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            CarsCreateViewModel model = new CarsCreateViewModel();

            return View(model);
        }

        // POST: Cars/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CarsCreateViewModel createModel)
        {
            if (ModelState.IsValid)
            {
                Car car = new Car
                {
                    Model = createModel.Model,
                    Brand = createModel.Brand,
                    Engine = createModel.Engine,
                    Year = createModel.Year
                };

                _context.Add(car);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(createModel);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            CarsEditViewModel model = new CarsEditViewModel
            {
                Id = car.Id,
                Model = car.Model,
                Year = car.Year,
                Engine = car.Engine,
                Brand = car.Brand
            };

            return View(model);
        }

        // POST: Cars/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CarsEditViewModel editModel)
        {
            if (ModelState.IsValid)
            {
                Car car = await _context.Cars.FindAsync(editModel.Id);
                car.Model = editModel.Model;
                car.Year = editModel.Year;
                car.Engine = editModel.Engine;
                car.Brand = editModel.Brand;

                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(editModel);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Car car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
