using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gtwave.App.Api.Controllers
{
    public class MusicoController : Controller
    {
        // GET: MusicoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MusicoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicoController/Create
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

        // GET: MusicoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MusicoController/Edit/5
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

        // GET: MusicoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicoController/Delete/5
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
