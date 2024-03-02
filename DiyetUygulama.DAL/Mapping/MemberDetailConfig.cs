using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
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
    public class MemberDetailConfig : IEntityTypeConfiguration<MemberDetail>
    {
        public void Configure(EntityTypeBuilder<MemberDetail> builder)
        {
            builder.HasKey(x => x.MemberDetailId);
            builder.Property(x => x.BirthDate).HasColumnType("datetime2");
            builder.Property(x => x.Gender);
            builder.Property(x => x.Height);
            builder.Property(x => x.Weight);
            builder.Property(x => x.FatRatio);
            builder.Property(x => x.IsDiabetes);
            builder.Ignore(x => x.Age);

            builder.HasData(new MemberDetail
            {
                MemberDetailId = 1,
                Gender = true,
                Height = 180,
                Weight = 100,
                FatRatio = 20,
                IsDiabetes = true,
                Allergy1 = Allergies.Milk,
                Allergy2 = Allergies.Egg,
                MemberId = 1,
                Status = BaseStatus.Deleted
            });
            builder.HasData(new MemberDetail
            {
                MemberDetailId = 2,
                Gender = true,
                Height = 180,
                Weight = 100,
                FatRatio = 20,
                IsDiabetes = true,
                Allergy1 = Allergies.Milk,
                Allergy2 = Allergies.Egg,
                MemberId = 2
            });
        }
    }
}
