using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Areas.Backoffice.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Backoffice/Categorias
        public ActionResult Index()
        {
            return View();
        }

        // GET: Backoffice/Categorias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Backoffice/Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Backoffice/Categorias/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Backoffice/Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Backoffice/Categorias/Edit/5
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

        // GET: Backoffice/Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Backoffice/Categorias/Delete/5
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
