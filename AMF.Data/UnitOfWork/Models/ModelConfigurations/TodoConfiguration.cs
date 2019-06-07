﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AMF.Data.UnitOfWork.Models.ModelConfigurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.CreatedOn).HasColumnType("TIMESTAMP(0)").IsRequired();

            builder.Property(prop => prop.Body)
                .HasMaxLength(1000);

            builder.Property(prop => prop.Title)
                .HasMaxLength(50).IsRequired();

            builder.Property(prop => prop.Body)
                .IsRequired();
        }
    }
}
