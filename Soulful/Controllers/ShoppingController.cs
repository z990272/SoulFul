using Soulful.Models;
using Soulful.Services;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class ShoppingController : Controller
    {

        ProductService _productService;
        ShoppingService _shoppingService;
        public ShoppingController()
        {
            _productService = new ProductService();
            _shoppingService = new ShoppingService();
        }
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int GetCartCount(int ProductId)
        {


            var ProductInCart = _productService.GetProductById(ProductId);
            _shoppingService.SetCurrentCart(ProductInCart);


            return _shoppingService.GetCartCount();
        }

        [HttpPost]
        public ActionResult AddToCart(int ProductId)
        {
            return PartialView("CartProductPartialView");
        }
        [HttpPost]
        public int ReduceProductCount(int ProductId)
        {
            _shoppingService.ReduceProductCount(ProductId);
            return _shoppingService.GetCartCount();
        }
        [HttpPost]
        public void ReduceCount(int ProductId)
        {
            _shoppingService.ReduceCount(ProductId);
        }
        [HttpPost]
        public void AddCount(int ProductId)
        {
            _shoppingService.AddCount(ProductId);
        }
    }
}