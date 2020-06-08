using Soulful.Models;
using Soulful.Services;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class ShoppingController : Controller
    {
        List<CartViewModel> cartItems = new List<CartViewModel>();

        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int GetCartCount(ProductViewModel productVM)
        {
            ProductService productService = new ProductService();

            var ProductInCart = productService.GetProductById(productVM.ProductId);

            if (Session["Cart"] == null)
            {

                CartViewModel cart = new CartViewModel
                {
                    RecordId = 1,
                    CartId = Guid.NewGuid().ToString(),
                    Id = ProductInCart.Album_id,
                    Name = ProductInCart.Album_Name,
                    Pic = ProductInCart.Pic,
                    Price = ProductInCart.Price
                };

                cartItems.Add(cart);

                Session["Cart"] = cartItems;
                Session["CartItemCount"] = cart.RecordId;
            }
            else
            {
                cartItems = (List<CartViewModel>)Session["Cart"]; //將Session中的購物車記錄還原成集合
                if (cartItems.All(x => x.Id != ProductInCart.Album_id))
                {
                    CartViewModel cart = new CartViewModel
                    {
                        RecordId = cartItems.Count() + 1,
                        CartId = Guid.NewGuid().ToString(),
                        Id = ProductInCart.Album_id,
                        Name = ProductInCart.Album_Name,
                        Pic = ProductInCart.Pic,
                        Price = ProductInCart.Price
                    };
                    cartItems.Add(cart);

                    Session["Cart"] = cartItems;
                    Session["CartItemCount"] = cart.RecordId;
                }

            }
            return cartItems.Count;
        }

        [HttpPost]
        public ActionResult AddToCart(ProductViewModel productVM)
        {
            return PartialView("CartProductPartialView");
        }

        [HttpPost]
        public ActionResult RemoveProduct(ProductViewModel productVM)
        {
            cartItems = (List<CartViewModel>)Session["Cart"]; //將Session中的購物車記錄還原成集合
            cartItems.Remove(cartItems.FirstOrDefault(x => x.Id == productVM.ProductId));
            Session["CartItemCount"] = cartItems.Count;
            return PartialView("CartPartialView");
        }
    }
}