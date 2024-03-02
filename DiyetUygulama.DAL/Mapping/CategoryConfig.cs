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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
            builder.Property(x => x.CategoryName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);

            builder.HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Et Ürünleri",
            });
            builder.HasData(new Category
            {
                CategoryId = 2,
                CategoryName = "Tavuk Ürünleri",
            });
            builder.HasData(new Category
            {
                CategoryId = 3,
                CategoryName = "Süt Ürünleri",
            });
            builder.HasData(new Category
            {
                CategoryId = 4,
                CategoryName = "Meyveler",
            });
            builder.HasData(new Category
            {
                CategoryId = 5,
                CategoryName = "Sebzeler",
            });
            builder.HasData(new Category
            {
                CategoryId = 6,
                CategoryName = "Çorbalar",
            });
            builder.HasData(new Category
            {
                CategoryId = 7,
                CategoryName = "Deniz Ürünleri",
            });
            builder.HasData(new Category
            {
                CategoryId = 8,
                CategoryName = "Baklagiller",
            });
            builder.HasData(new Category
            {
                CategoryId = 9,
                CategoryName = "Tatlılar",
            });
            builder.HasData(new Category
            {
                CategoryId = 10,
                CategoryName = "Tahıl Ürünleri",
            });
            builder.HasData(new Category
            {
                CategoryId = 11,
                CategoryName = "İçecekler",
            });
        }
    }
}
