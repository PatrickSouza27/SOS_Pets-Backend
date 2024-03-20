using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOSPets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSPets.Infra.Data.SQLite.Mapping
{
    internal class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("int")
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer");


            builder.Property(x => x.Neighborhood)
                .IsRequired()
                .HasColumnName("neighborhood")
                .HasColumnType("nvarchar")
                .HasMaxLength(260);


            builder.Property(x => x.City)
                .IsRequired()
                .HasColumnName("city")
                .HasColumnType("nvarchar")
                .HasMaxLength(260);

            builder.Property(x => x.Street)
                .IsRequired()
                .HasColumnName("street")
                .HasColumnType("nvarchar")
                .HasMaxLength(260);


            builder.Property(x => x.Number)
                .IsRequired();

            


        }
    }
}
