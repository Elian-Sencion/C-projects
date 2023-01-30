using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VentasOnline.Web.Models;

namespace VentasOnline.Web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public ActionResult Index()
        {
            List<ProductsModel> products = new List<ProductsModel>()
            {
                new ProductsModel()
                {
                    Id= 1,
                    Name = "Nvidia RTX 3090",
                    Description = "Tarjeta Grafica Alta Gama",
                    Price = 25000,
                    Quantity = 10
                },
                new ProductsModel()
                {
                    Id= 2,
                    Name = "Razer Blade 16",
                    Description = "Pc Portatil de Alta Gama",
                    Price = 70000,
                    Quantity = 5
                },
                new ProductsModel()
                {
                    Id = 3, 
                    Name = "Crua 27, 144/165HZ", 
                    Description = "Monitor Gaming de alta resolucion", 
                    Price = 12000,
                    Quantity = 15
                },

            };

            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
