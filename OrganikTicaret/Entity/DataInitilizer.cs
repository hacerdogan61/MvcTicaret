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
                new Category(){CategoryName = "Duş Başlıkları",Descriptions = "Duş Başlığı"},
                new Category(){CategoryName = "Duş Süzgeçleri",Descriptions = "Duş Süzgeçleri"},



            };
            foreach (var item in kategori)
            {
                context.cat.Add(item);
            }
            context.SaveChanges();

            var uruList = new List<Products>()
            {
                new Products(){ Name = "Duş Başlığı",ProductCode = "MIKS 660.360.33",Description = "Klasik Seri Plastik Duş Kanalı 360° Dirsek", DiametreandSize = "33 cm",OutputDirection = "Yan/Alt",OutputDiametre = "Q50",Price =26.00 , Stock =25 , IsApproved =true , CategoryId = 3,IsHome =true,Image ="mango.jpg"},
                new Products(){ Name = "Duş Başlığı",ProductCode = "MIKS 660.360.40",Description = "Klasik Seri Plastik Duş Kanalı 360° Dirsek", DiametreandSize = "40 cm",OutputDirection = "Yan/Alt",OutputDiametre = "Q50",Price =28.00 , Stock =25 , IsApproved =true , CategoryId= 3,IsHome = true,Image =""},
                new Products(){ Name = "Duş Başlığı",ProductCode = "MIKS 660.360.50",Description = "Klasik Seri Plastik Duş Kanalı 360° Dirsek", DiametreandSize = "50 cm",OutputDirection = "Yan/Alt",OutputDiametre = "Q50",Price =30.00 , Stock =25 , IsApproved =true , CategoryId = 3,IsHome = true,Image =""},
                new Products(){ Name = "Duş Başlığı",ProductCode = "MIKS 660.360.60",Description = "Klasik Seri Plastik Duş Kanalı 360° Dirsek", DiametreandSize = "60 cm",OutputDirection = "Yan/Alt",OutputDiametre = "Q50",Price =32.00 , Stock =25 , IsApproved =true , CategoryId = 3,IsHome = true,Image =""},
                new Products(){ Name = "Duş Başlığı",ProductCode = "MIKS 660.360.60",Description = "Klasik Seri Plastik Duş Kanalı 360° Dirsek", DiametreandSize = "60 cm",OutputDirection = "Yan/Alt",OutputDiametre = "Q50",Price =32.00 , Stock =25 , IsApproved =true , CategoryId = 3,IsHome = true,Image =""},




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