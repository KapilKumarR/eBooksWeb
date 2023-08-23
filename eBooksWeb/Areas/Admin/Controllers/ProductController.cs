using eBook.DataAccess.Repository;
using eBook.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBooksWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public ProductController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll().ToList();
            return View(objProductList);
        }
    }
}
