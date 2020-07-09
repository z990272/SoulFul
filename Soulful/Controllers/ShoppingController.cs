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

        List<CartViewModel> cartItems = new List<CartViewModel>();
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int GetCartCount(int ProductId)
        {

            ProductService productService = new ProductService();

            var ProductInCart = productService.GetProductById(ProductId);

            if (Session["Cart"] == null)
            {

                CartViewModel cart = new CartViewModel
                {
                    RecordId = 1,
                    Id = ProductInCart.Album_id,
                    Name = ProductInCart.Album_Name,
                    Pic = ProductInCart.Pic,
                    Price = ProductInCart.Price,
                    Count = 1,
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
                        Id = ProductInCart.Album_id,
                        Name = ProductInCart.Album_Name,
                        Pic = ProductInCart.Pic,
                        Price = ProductInCart.Price,
                        Count = 1
                    };
                    cartItems.Add(cart);

                    Session["Cart"] = cartItems;
                    Session["CartItemCount"] = cart.RecordId;
                }

            }
            return cartItems.Count;
        }

        [HttpPost]
        public ActionResult AddToCart(int ProductId)
        {
            return PartialView("CartProductPartialView");
        }
        [HttpPost]
        public int ReduceProductCount(int ProductId)
        {
            cartItems = (List<CartViewModel>)Session["Cart"]; //將Session中的購物車記錄還原成集合
            cartItems.Remove(cartItems.FirstOrDefault(x => x.Id == ProductId));
            Session["CartItemCount"] = cartItems.Count;
            return cartItems.Count;
        }
        [HttpPost]
        public ActionResult ReduceCount(int ProductId)
        {
            cartItems = (List<CartViewModel>)Session["Cart"]; //將Session中的購物車記錄還原成集合

            cartItems.FirstOrDefault(x => x.Id == ProductId).Count--;

            Session["Cart"] = cartItems;

            return new EmptyResult();
        }
        [HttpPost]
        public ActionResult AddCount(int ProductId)
        {
            cartItems = (List<CartViewModel>)Session["Cart"]; //將Session中的購物車記錄還原成集合

            cartItems.FirstOrDefault(x => x.Id == ProductId).Count++;

            Session["Cart"] = cartItems;

            return new EmptyResult();
        }
    }
}