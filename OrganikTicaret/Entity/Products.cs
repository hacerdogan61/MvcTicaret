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
        [DisplayName("Ürün Kodu")]
        public string ProductCode
        {
            get; set;
        }
        [DisplayName("Çıkış Çapı ve Ölçüsü")]
        public string DiametreandSize
        {
            get; set;
        }
        [DisplayName("Çıkış Yönü")]
        public string OutputDirection
        {
            get; set;
        }
        [DisplayName("Çıkış Çapı ")]
        public string OutputDiametre
        {
            get; set;
        }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stok")]
        public int Stock { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Anasayfa Görünümü")]
        public bool IsHome { get; set; }//Sayfalarda görülsü görülmesin
        [DisplayName("Stok Durumu")]
        public bool IsApproved { get; set; }//ürün stokta varsa sırala yoksa sıralama
        [DisplayName("Kategori Numarası")]
        public int CategoryId { get; set; }
        public Category Category { get; set;}
        public bool IsDelete { get; set; }
       
    }
}