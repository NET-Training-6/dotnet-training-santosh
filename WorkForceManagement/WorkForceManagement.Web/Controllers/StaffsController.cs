using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkForceManagement.Web.Controllers
{
    public class StaffsController : Controller
    {
        // GET: StaffsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StaffsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaffsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffsController/Create
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

        // GET: StaffsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaffsController/Edit/5
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

        // GET: StaffsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaffsController/Delete/5
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
