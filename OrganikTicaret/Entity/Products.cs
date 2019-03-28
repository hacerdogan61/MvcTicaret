using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OrganikTicaret.Entity
{
    public class Products
    {
        public int Id { get; set; }
        [DisplayName( "Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description {get; set;}
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stok")]
        public int Stock { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Anasayfa Görünümü")]
        public byte IsHome { get; set; }//Sayfalarda görülsü görülmesin
        [DisplayName("Stok Durumu")]
        public byte IsApproved { get; set; }//ürün stokta varsa sırala yoksa sıralama
        [DisplayName("Kategori Numarası")]
        public int CategoryId { get; set; }
        public Category Category { get; set;}
       
    }
}