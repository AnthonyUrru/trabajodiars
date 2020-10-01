using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace FinancistoCloneWeb.Models.Maps
{
    public class TransactionMap : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(o => o.Id);

            //builder.HasOne(o => o.Type)
            //    .WithMany(o => o.Accounts)
            //    .HasForeignKey(o => o.TypeId);
            builder.HasOne(o => o.Account)
                .WithMany()
                .HasForeignKey(o => o.CuentaId);
        }
    }
}
