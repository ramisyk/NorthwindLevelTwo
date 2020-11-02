using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService = null)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            //ürünü çek
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.AddToCart(cart,product);

            _cartSessionHelper.SetCart("cart", cart);
            TempData.Add("message", product.ProductName + " sepete eklendi!");

            return RedirectToAction("Index", "Product");
        }
        public IActionResult RemoveFromCart(int productId)
        {
            //ürünü çek
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.RemoveFromCart(cart, productId);

            _cartSessionHelper.SetCart("cart", cart);
            TempData.Add("message", product.ProductName + " sepetten silindi!");

            return RedirectToAction("Index", "Cart");
        }
        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModal
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Complete (ShippingDetail shippingDetail)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            
            TempData.Add("message", "Siparişiniz başarıyla tamamlandı!!!");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Cart");
            
        }
        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };
            return View(model);
        }
    }
}
