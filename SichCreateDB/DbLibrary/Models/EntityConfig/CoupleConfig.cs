﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DbLibrary.Models.Entity;

namespace DbLibrary.Models.EntityConfig
{
    public class CoupleConfig : IEntityTypeConfiguration<Couple>
    {
        public void Configure(EntityTypeBuilder<Couple> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();
            builder.Property(c => c.Day)
                .IsRequired();
            //    .HasComputedColumnSql("CHECK(Day >= 0 AND Day <= 6)");
            builder.Property(c => c.LessonType)
                .IsRequired();
            //    .HasComputedColumnSql("CHECK(LessonType >= 0 AND LessonType <= 2)");
            builder.Property(c => c.Numerator)
                .IsRequired();
            builder.Property(c => c.Denomirator)
                .IsRequired();
              //  .HasComputedColumnSql("CHECK((Numerator = 0 AND Denomirator = 1) OR (Numerator = 1 AND Denomirator = 0) OR (Numerator = 1 AND Denomirator = 1))");
            builder.HasOne(c => c.Para)
                .WithOne(dt => dt.Couple)
                .HasForeignKey<Couple>(c => c.ParaId);
            builder.HasOne(c => c.Room)
                .WithOne(r => r.Couple)
                .HasForeignKey<Couple>(c => c.RoomId);
            builder.HasOne(c => c.Subject)
                .WithOne(s => s.Couple)
                .HasForeignKey<Couple>(c => c.SubjectId);
            builder.HasOne(c => c.Teacher)
                .WithOne(t => t.Couple)
                .HasForeignKey<Couple>(c => c.TeacherId);
        }
    }
}
