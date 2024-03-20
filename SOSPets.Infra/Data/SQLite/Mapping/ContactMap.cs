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
    internal class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("int")
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer");


            builder.Property(x => x.Phone)
                .IsRequired()
                .HasColumnName("phone")
                .HasColumnType("nvarchar")
                .HasMaxLength(30);


            builder.Property(x => x.WhatsappNumber)
                 .HasColumnName("phone")
                 .HasColumnType("nvarchar");


        }
    }
}
