using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Configuration
{
    public class BooksConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.HasKey(x => x.BooksId);
            builder.Property(x => x.BooksId).UseIdentityColumn();
            builder.Property(x => x.Name);
            builder.Property(x => x.CurrentLoanId);
            builder.Property(x => x.ISBN).IsRequired().HasMaxLength(13);
            builder.Property(x => x.Image);
            builder.Property(x => x.BookStatus);
            builder.Property(x => x.Description);
            builder.ToTable(nameof(Books));

            builder.HasOne(x=>x.Category).WithMany(x=>x.Books).HasForeignKey(x=>x.CategoryId);
        }
    }
}