using LabExam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabExam.Controllers
{
    public class ProductController : Controller
    {
        // GET: productController
        public ActionResult Index()
        {
            List<product> pro = product.GetAllProduct();
            return View (pro);
        }

        // GET: productController/Details/5
        public ActionResult Details(int id)
        {
            product obj = product.GetSingleProduct(id);
            return View(obj);
        }

        // GET: productController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: productController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(product obj, IFormCollection collection)
        {
            try
            {
                product.InsertProduct(obj);
                ViewBag.message = "Success!";
                return View();
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                return View();
            }
        }

        // GET: productController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            product obj = product.GetSingleProduct(id.Value);
            return View(obj);
        }

        // POST: productController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, product obj)
        {
            try
            {
                product.UpdateProduct(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                return View();
            }
        }

        // GET: productController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            product obj = product.GetSingleProduct(id.Value);
            return View(obj);
        }

        // POST: productController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, product obj)
        {
            try
            {
                product.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                return View();
            }




        }

    }
}
        