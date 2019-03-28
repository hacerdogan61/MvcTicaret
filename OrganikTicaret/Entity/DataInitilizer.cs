using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrganikTicaret.Entity
{
    public class DataInitilizer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori=new List<Category>()
            {
                new Category(){CategoryName = "Armut",Descriptions = "Organik Meyve"},
                new Category(){CategoryName = "Salatalık",Descriptions = "Organik Sebze"},
                new Category(){CategoryName = "Bal",Descriptions = "Organik Ürün"},
                new Category(){CategoryName = "Süt",Descriptions = "Organik Süt"}



            };
            foreach (var item in kategori)
            {
                context.cat.Add(item);
            }
            context.SaveChanges();

            var uruList = new List<Products>()
            {
                new Products(){ Name = "Organik Muz",Description = "Muz yüksek mineral içeriği ile faydalı bir besindir. Potasyum, manganez, C ve B6 vitaminleriyle doludur.", Price =15 , Stock =500 , IsApproved =1 , CategoryId = 1,IsHome = 1,Image ="mango.jpg"},
                new Products(){ Name = "Organik Portakal",Description = "Portakal C vitamin deposudur. Vücudun bağışıklık sistemini güçlendirir ve enerji verir. İster meyve olarak yiyin, isterseniz suyunu sıkıp ailece için. City Farm Organik Portakal, tamamen karpitsiz, filesinde, taze ve mevsiminde.", Price =1200 , Stock =500 , IsApproved =1 , CategoryId = 1,IsHome = 1,Image ="mango.jpg"},
                new Products(){ Name = "Organik Limon",Description = "Bir mutfağın vazgeçilmezlerinden biri: C vitamini deposu, City Farm Organik Limon. Filesinde, sizler için dalından koparıldığı tazelikte.", Price =1200 , Stock =500 , IsApproved =1 , CategoryId = 1,IsHome = 1,Image ="mango.jpg"},
                new Products(){ Name = " Organik Elma Sirkesi.",Description = "Salatalarınıza ve diğer gıdalarınıza City Farm Organik Elma Sirkesiyle farklı bir tat ekleyin.", Price =1200 , Stock =500 , IsApproved =1 , CategoryId = 1,IsHome = 1,Image ="mango.jpg"},
                new Products(){ Name = "Organik Domates Salçası 660 gr.",Description = "Organik Domates Salçası ile yemeklerinize yeni bir boyut ekleyin.Organik Domates.", Price =1200 , Stock =500 , IsApproved =1, IsHome = 1,CategoryId = 1,Image ="mango.jpg"},

              


            };
            foreach (var urun in uruList)
            {
                context.pro.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}