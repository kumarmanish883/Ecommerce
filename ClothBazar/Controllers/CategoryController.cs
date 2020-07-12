using ClothBazar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService categoryservice = new CategoryService();
        [HttpGet]
        public ActionResult Index()
        {
            var categoriesss = categoryservice.GetCategories();

            return View(categoriesss);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryservice.SaveCategory(category);


            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var categor = categoryservice.GetCategory(ID);
            return View(categor);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryservice.UpdateCategory(category);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var categor = categoryservice.GetCategory(ID);

            return View(categor);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            categoryservice.DeleteCategory(category.ID);


            return RedirectToAction("Index");
        }

    }
}