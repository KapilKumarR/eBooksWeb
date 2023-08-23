using eBooksWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System.Net;
using eBook.DataAccess;
using eBook.DataAccess.Repository;
using eBook.DataAccess.Repository.IRepository;

namespace eBooksWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofwork;
        Category obj = new Category();
        public CategoryController(IUnitOfWork unitOfwork)
        {
            _unitofwork = unitOfwork;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitofwork.Category.GetAll().ToList();
            return View(objCategoryList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder Cannot Exactly match to Name");
            }
            if (ModelState.IsValid)
            {
                _unitofwork.Category.Add(obj);
                _unitofwork.Save();
                TempData["create"] = "Created Successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _unitofwork.Category.Get(u=>u.Id==id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            if (ModelState.IsValid)
            {
                _unitofwork.Category.Update(category);
                _unitofwork.Save();
                TempData["edit"] = "Updated Successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _unitofwork.Category.Get(u => u.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb); 
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id) 
        {
            Category? categoryfromDB = _unitofwork.Category.Get(u => u.Id== id);
            if (categoryfromDB == null)
            {
                return NotFound();
            }
            _unitofwork.Category.Remove(categoryfromDB);
            _unitofwork.Save();

            TempData["delete"] = "Deleted Successfully";
            return RedirectToAction("Index", "Category");
        }

    }
}
