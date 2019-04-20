using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrganikTicaret.Entity;

namespace OrganikTicaret.Models
{
    public class Cart
    {
        public List<CartLine> cartline=new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return cartline; }
        }

        public void AddProduct(Products products,int quantitiy)
        {
            var line = cartline.FirstOrDefault(i => i.product.Id == products.Id);
            if (line==null)
            {
                cartline.Add(new CartLine(){product = products,Quantity = quantitiy});
            }
            else
            {
                line.Quantity += quantitiy;

            }
        }
        public void DeleteProduct(Products pr)
        {
            cartline.RemoveAll(i=>i.product.Id==pr.Id);
        }
        public double Total()
        {
            return cartline.Sum(i => i.product.Price * i.Quantity);
        }
        public void Clear()
        {
            cartline.Clear();
        }
    }
    public class CartLine
    {
        public Products product { get; set; }
        public int Quantity { get; set; }
    }
}