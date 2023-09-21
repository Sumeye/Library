using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Configuration
{
    public class LoanConfiguration: IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(x => x.LoanId);
            builder.Property(x => x.LoanId).UseIdentityColumn();
            builder.Property(x => x.Name);
            builder.Property(x => x.SurName);
            builder.Property(x => x.ReturnDate);
            builder.Property(x => x.DeliveryDate);

            builder.ToTable(nameof(Loan));

          
        }
    }
}
