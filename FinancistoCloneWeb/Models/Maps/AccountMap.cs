using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models.Maps
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(o => o.Id);

            //builder.HasOne(o => o.Type)
            //    .WithMany(o => o.Accounts)
            //    .HasForeignKey(o => o.TypeId);

            builder.HasOne(o => o.Type)
                .WithMany()
                .HasForeignKey(o => o.TypeId);

            builder.HasOne(o => o.transaction)
                .WithMany()
                .HasForeignKey(o => o.transactionId);


        }
    }
}
