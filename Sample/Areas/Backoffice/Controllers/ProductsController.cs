using Sample.DAL;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Areas.Backoffice.Controllers
{
    public class ProductsController : Controller
    {
        SampleContext db = new SampleContext();

        // GET: Backoffice/Produtos
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Backoffice/Produtos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Backoffice/Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Backoffice/Produtos/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name, Description, Price, PriceInPromotion, Quantity")]Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Backoffice/Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Backoffice/Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Backoffice/Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Backoffice/Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
