using DiyetUygulama.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DiyetUygulama.DAL.Mapping
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductId);
            builder.Property(x=>x.ProductName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Calories).IsRequired();
            builder.Property(x => x.PhotoPath).HasColumnType("nvarchar").HasMaxLength(225);

            builder.HasData(new Product
            {
                ProductId = 1,
                ProductName = "Bonfile",
                Protein = 34.5,
                Carbonhydrate = 2.6,
                Fat = 10.56,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 dilim",
                Unit = "g",
                Calories = 100,
                Amount = 120,
                CategoryId = 1,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\bonfile.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 2,
                ProductName = "Pilav",
                Protein = 5.2,
                Carbonhydrate = 45.8,
                Fat = 1.3,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 porsiyon",
                Unit = "g",
                Calories = 200,
                Amount = 150,
                CategoryId = 8,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\pilav.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 3,
                ProductName = "Pizza",
                Protein = 12.5,
                Carbonhydrate = 30.0,
                Fat = 15.8,
                HasGluten = true,
                HasLactose = true,
                Portion = "1 dilim",
                Unit = "g",
                Calories = 300,
                Amount = 100,
                CategoryId = 10,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\pizza.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 4,
                ProductName = "Makarna",
                Protein = 8.0,
                Carbonhydrate = 40.5,
                Fat = 2.3,
                HasGluten = true,
                HasLactose = false,
                Portion = "100 gram",
                Unit = "g",
                Calories = 250,
                Amount = 100,
                CategoryId = 10,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\makarna.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 5,
                ProductName = "Lahmacun",
                Protein = 10.0,
                Carbonhydrate = 30.5,
                Fat = 8.7,
                HasGluten = true,
                HasLactose = false,
                Portion = "1 adet",
                Unit = "g",
                Calories = 280,
                Amount = 150,
                CategoryId = 10,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\lahmacun.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 6,
                ProductName = "Dondurma",
                Protein = 4.0,
                Carbonhydrate = 25.5,
                Fat = 12.3,
                HasGluten = true,
                HasLactose = true,
                Portion = "1 top",
                Unit = "g",
                Calories = 200,
                Amount = 100,
                CategoryId = 3,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\dondurma.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 7,
                ProductName = "İskender",
                Protein = 20.0,
                Carbonhydrate = 40.0,
                Fat = 15.5,
                HasGluten = true,
                HasLactose = true,
                Portion = "1 porsiyon",
                Unit = "g",
                Calories = 400,
                Amount = 200,
                CategoryId = 1,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\iskender.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 8,
                ProductName = "Mercimek Çorbası",
                Protein = 8.5,
                Carbonhydrate = 20.0,
                Fat = 3.2,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 kase",
                Unit = "g",
                Calories = 150,
                Amount = 250,
                CategoryId = 6,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\çorba.jpg"
            });

            builder.HasData(new Product
            {
                ProductId = 9,
                ProductName = "Sütlaç",
                Protein = 5.0,
                Carbonhydrate = 30.5,
                Fat = 8.0,
                HasGluten = false,
                HasLactose = true,
                Portion = "1 porsiyon",
                Unit = "g",
                Calories = 250,
                Amount = 150,
                CategoryId = 9,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\sütlaç.jpg"
            });

            builder.HasData(new Product
            {
                ProductId = 10,
                ProductName = "Menemen",
                Protein = 15.0,
                Carbonhydrate = 10.5,
                Fat = 12.8,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 porsiyon",
                Unit = "g",
                Calories = 300,
                Amount = 200,
                CategoryId = 2,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\menemen.png"
            });
            builder.HasData(new Product
            {
                ProductId = 11,
                ProductName = "Hamsi",
                Protein = 25.0,
                Carbonhydrate = 0.5,
                Fat = 10.2,
                HasGluten = false,
                HasLactose = false,
                Portion = "100 gram",
                Unit = "g",
                Calories = 180,
                Amount = 100,
                CategoryId = 7,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\hamsi.jpg"
            });
            builder.HasData(new Product
            {
                ProductId = 12,
                ProductName = "Cacık",
                Protein = 2.0,
                Carbonhydrate = 6.5,
                Fat = 5.0,
                HasGluten = false,
                HasLactose = true,
                Portion = "1 kase",
                Unit = "g",
                Calories = 100,
                Amount = 150,
                CategoryId = 3,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\cacık.jpg"
            });

            builder.HasData(new Product
            {
                ProductId = 13,
                ProductName = "Ekmek",
                Protein = 3.0,
                Carbonhydrate = 15.0,
                Fat = 1.0,
                HasGluten = true,
                HasLactose = false,
                Portion = "1 dilim",
                Unit = "g",
                Calories = 70,
                Amount = 30,
                CategoryId = 10,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\ekmek.jpeg"
            });


            builder.HasData(new Product
            {
                ProductId = 14,
                ProductName = "Çay",
                Protein = 0.5,
                Carbonhydrate = 10.0,
                Fat = 0.1,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 fincan",
                Unit = "ml",
                Calories = 5,
                Amount = 150,
                CategoryId = 11,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\çay.jpeg"
            });


            builder.HasData(new Product
            {
                ProductId = 15,
                ProductName = "Sushi",
                Protein = 15.0,
                Carbonhydrate = 35.0,
                Fat = 5.0,
                HasGluten = true,
                HasLactose = false,
                Portion = "1 porsiyon",
                Unit = "g",
                Calories = 300,
                Amount = 100,
                CategoryId = 7,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\suşi.jpeg"
            });

            builder.HasData(new Product
            {
                ProductId = 16,
                ProductName = "Bal",
                Protein = 0.3,
                Carbonhydrate = 17.3,
                Fat = 0.0,
                HasGluten = false,
                HasLactose = false,
                Portion = "1 yemek kaşığı",
                Unit = "g",
                Calories = 64,
                Amount = 21,
                CategoryId = 9,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\bal.jpeg"
            });


            builder.HasData(new Product
            {
                ProductId = 17,
                ProductName = "Zeytin",
                Protein = 0.8,
                Carbonhydrate = 0.2,
                Fat = 15.0,
                HasGluten = false,
                HasLactose = false,
                Portion = "10 adet",
                Unit = "g",
                Calories = 120,
                Amount = 50,
                CategoryId = 4,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\zeytin.jpeg"
            });


            builder.HasData(new Product
            {
                ProductId = 18,
                ProductName = "İncir",
                Protein = 1.0,
                Carbonhydrate = 18.0,
                Fat = 0.3,
                HasGluten = false,
                HasLactose = false,
                Portion = "2 adet",
                Unit = "g",
                Calories = 80,
                Amount = 100,
                CategoryId = 4,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\incir.jpeg"
            });

            builder.HasData(new Product
            {
                ProductId = 19,
                ProductName = "Yumurta",
                Protein = 6.7,
                Carbonhydrate = 0.6,
                Fat = 5.5,
                HasGluten = false,
                HasLactose = true,
                Portion = "1 adet",
                Unit = "g",
                Calories = 68,
                Amount = 50,
                CategoryId = 2,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\yumurta.jpeg"
            });


            builder.HasData(new Product
            {
                ProductId = 20,
                ProductName = "Beyaz Peynir",
                Protein = 17.0,
                Carbonhydrate = 2.0,
                Fat = 21.0,
                HasGluten = false,
                HasLactose = true,
                Portion = "1 dilim",
                Unit = "g",
                Calories = 250,
                Amount = 30,
                CategoryId = 3,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\beyazpeynir.jpg"
            });


            builder.HasData(new Product
            {
                ProductId = 21,
                ProductName = "Çiğköfte",
                Protein = 12.0,
                Carbonhydrate = 20.0,
                Fat = 15.5,
                HasGluten = true,
                HasLactose = false,
                Portion = "100 gram",
                Unit = "g",
                Calories = 300,
                Amount = 100,
                CategoryId = 8,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\çiğköfte.JPG"
            });
            builder.HasData(new Product
            {
                ProductId = 22,
                ProductName = "Süt",
                Protein = 8.0,
                Carbonhydrate = 12.0,
                Fat = 3.5,
                HasGluten = false,
                HasLactose = true,
                Portion = "1 bardak",
                Unit = "ml",
                Calories = 120,
                Amount = 250,
                CategoryId = 11,
                MealId = 1,
                Visible = true,
                PhotoPath = "FoodPictures\\milk.jpg"
            });
        }
    }
}
