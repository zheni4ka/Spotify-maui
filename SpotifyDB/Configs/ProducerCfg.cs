﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDB.Configs
{
    public class ProducerCfg //: IEntityTypeConfiguration<Producer>
    {
        //public void Configure(EntityTypeBuilder<Producer> builder)
        //{
        //    builder.HasKey(x => x.Id);
        //    builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
        //    builder.Property(x => x.CountryId).IsRequired();

        //    builder.HasMany(x => x.Artists).WithOne(x => x.Producer).HasForeignKey(x => x.ProducerId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        //    builder.HasOne(x => x.Country).WithMany(x => x.Producers).HasForeignKey(x => x.CountryId).IsRequired();
        //}
    }
}
