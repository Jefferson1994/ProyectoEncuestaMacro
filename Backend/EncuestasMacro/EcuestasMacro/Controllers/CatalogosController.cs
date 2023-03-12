using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcuestasMacro.Controllers
{
    public class CatalogosController : Controller
    {
        // GET: CatalogosController
        public ActionResult GetCatalogos()
        {
            return View();
        }

        // GET: CatalogosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatalogosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatalogosController/Create
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

        // GET: CatalogosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatalogosController/Edit/5
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

        // GET: CatalogosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatalogosController/Delete/5
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
