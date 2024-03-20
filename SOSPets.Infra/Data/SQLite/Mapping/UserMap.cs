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
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("int")
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer");


            builder.Property(x => x.Email)
                .HasColumnName("email")
                .HasColumnType("nvarchar")
                .HasMaxLength(260);

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasColumnName("lastName")
                .HasColumnType("nvarchar")
                .HasMaxLength(260);


            builder.Property(x => x.Cpf)
                .HasColumnName("cpf")
                .HasColumnType("nvarchar")
                .HasMaxLength(20);

            builder.Property(x => x.UrlPhoto)
                .HasColumnName("urlPhoto")
                .HasColumnType("nvarchar")
                .HasMaxLength(430);

            builder.Property(x => x.Birthday)
                .IsRequired()
                .HasColumnName("birthday")
                .HasColumnType("date");

                

            
        }
    }
}
