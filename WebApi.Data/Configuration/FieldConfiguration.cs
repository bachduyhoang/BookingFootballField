﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.ToTable("Field");
            builder.HasKey(x => x.FieldId);
            builder.HasOne(x => x.GroupField).WithMany(x => x.Fields)
                .HasForeignKey(x => x.GroupFieldForeinKey);
        }
    }
}