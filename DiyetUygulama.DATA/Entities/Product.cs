﻿using DiyetUygulama.DATA.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DATA.Entities
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Calories { get; set; }
        public string PhotoPath { get; set; }


        //Navigation Proporties
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
       

    }
}