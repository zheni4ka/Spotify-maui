﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDB.Configs
{
    public class ArtistCfg //: IEntityTypeConfiguration<Artist>
    {
        //public void Configure(EntityTypeBuilder<Artist> builder)
        //{
        //    builder.HasKey(x => x.Id);
        //    builder.Property(x => x.Nickname).HasMaxLength(150).IsRequired();
        //    builder.Property(x => x.BirthDate).IsRequired();


        //    builder.HasMany(x => x.Albums).WithOne(x => x.Artist).HasForeignKey(x => x.ArtistId).IsRequired();
        //    builder.HasOne(x => x.Country).WithMany(x => x.Artists).HasForeignKey(x => x.CountryId).IsRequired();
        //}
    }
}
