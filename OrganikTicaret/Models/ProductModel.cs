﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganikTicaret.Models
{
    public class ProductModel
    {


        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
       
        public string ProductCode
        {
            get; set;
        }
   
        public string DiametreandSize
        {
            get; set;
        }
      
        public string OutputDirection
        {
            get; set;
        }
        public string OutputDiametre
        {
            get; set;
        }
        public double Price
        {
            get; set;
        }
        public int Stock
        {
            get; set;
        }
        public string Image
        {
            get; set;
        }
     
        public int CategoryId
        {
            get; set;
        }
    }
}