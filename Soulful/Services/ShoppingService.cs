using Microsoft.Ajax.Utilities;
using Soulful.Models;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Soulful.Services
{
    public class ShoppingService
    {
        List<CartViewModel> _cartItems;
        public ShoppingService()
        {
            _cartItems = new List<CartViewModel>();
        }

        public void SetCurrentCart(Album ProductInCart)
        {
            if (HttpContext.Current.Session["Cart"] == null)
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

                _cartItems.Add(cart);

                HttpContext.Current.Session["Cart"] = _cartItems;
                HttpContext.Current.Session["CartItemCount"] = cart.RecordId;
            }
            else
            {
                _cartItems = (List<CartViewModel>)HttpContext.Current.Session["Cart"]; //將Session中的購物車記錄還原成集合
                if (_cartItems.All(x => x.Id != ProductInCart.Album_id))
                {
                    CartViewModel cart = new CartViewModel
                    {
                        RecordId = _cartItems.Count() + 1,
                        Id = ProductInCart.Album_id,
                        Name = ProductInCart.Album_Name,
                        Pic = ProductInCart.Pic,
                        Price = ProductInCart.Price,
                        Count = 1
                    };
                    _cartItems.Add(cart);

                    HttpContext.Current.Session["Cart"] = _cartItems;
                    HttpContext.Current.Session["CartItemCount"] = cart.RecordId;
                }
            }
        }
        public int GetCartCount()
        {
            return _cartItems.Count;
        }
        public void ReduceProductCount(int ProductId)
        {
            _cartItems = (List<CartViewModel>)HttpContext.Current.Session["Cart"];
            _cartItems.Remove(_cartItems.FirstOrDefault(x => x.Id == ProductId));
            HttpContext.Current.Session["CartItemCount"] = _cartItems.Count;
        }
        public void ReduceCount(int ProductId)
        {
            _cartItems = (List<CartViewModel>)HttpContext.Current.Session["Cart"];
            _cartItems.FirstOrDefault(x => x.Id == ProductId).Count--;
            HttpContext.Current.Session["Cart"] = _cartItems;
        }
        public void AddCount(int ProductId)
        {
            _cartItems = (List<CartViewModel>)HttpContext.Current.Session["Cart"];
            _cartItems.FirstOrDefault(x => x.Id == ProductId).Count++;
            HttpContext.Current.Session["Cart"] = _cartItems;
        }
        public decimal GetTotalAmount()
        {
            _cartItems = (List<CartViewModel>)HttpContext.Current.Session["Cart"];
            var TotalAmount = _cartItems.Sum(x => x.Price * x.Count);
            return TotalAmount;

        }


    }
}